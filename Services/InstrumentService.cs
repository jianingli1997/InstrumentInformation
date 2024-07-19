using InstrumentInformation.Data;
using InstrumentInformation.Models.DTOs.QueryDTO;
using InstrumentInformation.Models.Entity;
using InstrumentInformation.Models.Responses;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace InstrumentInformation.Services
{
    public class InstrumentService : IInstrumentService
    {
        private readonly DataContext _context;

        public InstrumentService(DataContext context)
        {
            _context = context;
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