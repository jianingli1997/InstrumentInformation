using InstrumentInformation.Models.DTOs.EntityDTO.InstrumentDTO;
using InstrumentInformation.Models.DTOs.QueryDTO;
using InstrumentInformation.Models.Entity.Instrument;
using InstrumentInformation.Models.Responses;

namespace InstrumentInformation.Services.InstrumentService
{
    public interface IInstrumentService
    {
        /// <summary>
        /// 获取所有器械种类
        /// </summary>
        /// <returns></returns>
        Task<ServiceResponse<List<Instrument>>> GetAllInstruments();


        /// <summary>
        /// 根据器械序列号获取器械
        /// </summary>
        /// <param name="serialNumber"></param>
        /// <returns></returns>
        Task<ServiceResponse<Instrument>> GetInstrumentBySerialNumber(string serialNumber);


        /// <summary>
        /// 获取某种器械种类的所有器械
        /// </summary>
        /// <param name="instrumentTypeName"></param>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        Task<PagedServiceResponse<List<Instrument>>> GetInstrumentsByInstrumentType(string instrumentTypeName, int pageNumber, int pageSize);

        /// <summary>
        /// 动态参数查询器械
        /// </summary>
        /// <param name="queryParams"></param>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        Task<PagedServiceResponse<List<Instrument>>> GetInstrumentsByQueryParams(InstrumentQueryParams queryParams, int pageNumber, int pageSize);

        Task<ServiceResponse<bool>> AddInstrument(InstrumentDTO instrumentDto);

        Task<ServiceResponse<InstrumentDTO>> UpdateInstrument(InstrumentDTO instrumentDto);

        Task<ServiceResponse<bool>> DeleteInstrument(int instrumentId);
    }
}
