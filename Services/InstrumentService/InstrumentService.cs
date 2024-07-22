using InstrumentInformation.Data;
using InstrumentInformation.Models.DTOs.QueryDTO;
using InstrumentInformation.Models.Responses;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using InstrumentInformation.Models.DTOs.EntityDTO.InstrumentDTO;
using InstrumentInformation.Models.Entity.Instrument;

namespace InstrumentInformation.Services.InstrumentService
{
    public class InstrumentService : IInstrumentService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public InstrumentService(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<List<Instrument>>> GetAllInstruments()
        {
            List<Instrument> instruments = await _context.Instruments.ToListAsync();
            ServiceResponse<List<Instrument>> response = new()
            {
                Data = instruments
            };
            return response;
        }

        public async Task<ServiceResponse<Instrument>> GetInstrumentBySerialNumber(string serialNumber)
        {
            Instrument instrument = await _context.Instruments.FirstOrDefaultAsync(i => i.SerialNumber == serialNumber);
            if (instrument == null)
            {
                return new ServiceResponse<Instrument>
                {
                    Success = false,
                    Message = "找不到该器械"
                };
            }

            return new ServiceResponse<Instrument>
            {
                Data = instrument
            };
        }

        public async Task<PagedServiceResponse<List<Instrument>>> GetInstrumentsByInstrumentType(
            string instrumentTypeName, int pageNumber, int pageSize)
        {
            try
            {
                InstrumentType? instrumentType = await _context.InstrumentTypes
                    .FirstOrDefaultAsync(it => it.Name == instrumentTypeName);

                if (instrumentType == null)
                {
                    return new PagedServiceResponse<List<Instrument>>
                    {
                        Success = false,
                        Message = "不存在该器械类型"
                    };
                }

                int totalRecords = await _context.Instruments
                    .CountAsync(i => i.InstrumentTypeId == instrumentType.Id);
                if (totalRecords == 0)
                {
                    return new PagedServiceResponse<List<Instrument>>
                    {
                        Success = false,
                        Message = "不存在该类型的器械"
                    };
                }

                List<Instrument> instruments = await _context.Instruments
                    .Where(i => i.InstrumentTypeId == instrumentType.Id)
                    .Skip((pageNumber - 1) * pageSize)
                    .Take(pageSize)
                    .ToListAsync();

                return new PagedServiceResponse<List<Instrument>>
                {
                    Success = true,
                    Data = instruments,
                    PageNumber = pageNumber,
                    PageSize = pageSize,
                    TotalRecords = totalRecords
                };
            }
            catch (Exception ex)
            {
                return new PagedServiceResponse<List<Instrument>>
                {
                    Success = false,
                    Message = $" {ex.Message}"
                };
            }
        }

        public async Task<PagedServiceResponse<List<Instrument>>> GetInstrumentsByQueryParams(
            InstrumentQueryParams queryParams, int pageNumber, int pageSize)
        {
            IQueryable<Instrument> query = _context.Instruments.AsQueryable();

            // 应用过滤器
            query = ApplyFilters(query, queryParams);

            // 获取总数
            int totalCount = await query.CountAsync();

            // 分页
            List<Instrument> instruments = await query
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            // 创建响应
            PagedServiceResponse<List<Instrument>> response = new()
            {
                Data = instruments,
                PageNumber = pageNumber,
                PageSize = pageSize,
                TotalRecords = totalCount
            };

            return response;
        }

        public async Task<ServiceResponse<bool>> AddInstrument(InstrumentDTO instrumentDto)
        {
            bool isExist = await _context.Instruments.AnyAsync(i => i.SerialNumber == instrumentDto.SerialNumber);
            if (isExist)
            {
                return new ServiceResponse<bool>
                {
                    Success = false,
                    Message = "器械已存在"
                };
            }
            var instrument = _mapper.Map<Instrument>(instrumentDto);
            await _context.Instruments.AddAsync(instrument);
            await _context.SaveChangesAsync();
            return new ServiceResponse<bool>
            {
                Data = true,
                Message = "器械已添加"
            };

        }

        public async Task<ServiceResponse<InstrumentDTO>> UpdateInstrument(InstrumentDTO instrumentDto)
        {
            var instrument = await _context.Instruments.FirstOrDefaultAsync(i => i.SerialNumber == instrumentDto.SerialNumber);
            if (instrument == null)
            {
                return new ServiceResponse<InstrumentDTO>
                {
                    Success = false,
                    Message = "找不到该器械"
                };
            }

            instrument = _mapper.Map(instrumentDto, instrument);
            _context.Instruments.Update(instrument);
            await _context.SaveChangesAsync();
            return new ServiceResponse<InstrumentDTO>
            {
                Data = instrumentDto,
                Message = "器械已更新"
            };
        }

        public async Task<ServiceResponse<bool>> DeleteInstrument(int instrumentId)
        {
            bool isExist = await _context.Instruments.AnyAsync(i => i.Id == instrumentId);
            if (!isExist)
            {
                return new ServiceResponse<bool>
                {
                    Success = false,
                    Message = "找不到该器械"
                };
            }
            _context.Instruments.Remove(new Instrument { Id = instrumentId });
            await _context.SaveChangesAsync();
            return new ServiceResponse<bool>
            {
                Data = true,
                Message = "器械已删除"
            };
        }


        private IQueryable<Instrument> ApplyFilters(IQueryable<Instrument> query, InstrumentQueryParams queryParams)
        {
            // 处理日期条件
            foreach (QueryCondition<DateTime?> condition in queryParams.DateConditions)
            {
                if (condition.SingleValue.HasValue)
                {
                    // 等于某个日期
                    query = query.Where(i => i.CreatedDate == condition.SingleValue.Value);
                }

                if (condition.MinValue.HasValue)
                {
                    // 大于或等于某个日期
                    query = query.Where(i => i.CreatedDate >= condition.MinValue.Value);
                }

                if (condition.MaxValue.HasValue)
                {
                    // 小于或等于某个日期
                    query = query.Where(i => i.CreatedDate <= condition.MaxValue.Value);
                }
            }

            // 处理字符串条件
            query = (from condition in queryParams.StringConditions
                     where !string.IsNullOrEmpty(condition.SingleValue)
                     select $"%{condition.SingleValue}%").Aggregate(query,
                (current, searchValue) => current.Where(i => EF.Functions.Like(i.Name, searchValue)));

            // 处理整数条件
            foreach (QueryCondition<int?> condition in queryParams.IntConditions)
            {
                if (condition.SingleValue.HasValue)
                {
                    // 等于某个值
                    query = query.Where(i => i.UsableCount == condition.SingleValue.Value);
                }

                if (condition.MinValue.HasValue)
                {
                    // 大于或等于某个值
                    query = query.Where(i => i.UsableCount >= condition.MinValue.Value);
                }

                if (condition.MaxValue.HasValue)
                {
                    // 小于或等于某个值
                    query = query.Where(i => i.UsableCount <= condition.MaxValue.Value);
                }
            }

            return query;
        }
    }
}