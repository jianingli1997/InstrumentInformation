using InstrumentInformation.Models.DTOs.QueryDTO;
using InstrumentInformation.Models.Entity;
using InstrumentInformation.Models.Responses;
using InstrumentInformation.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InstrumentInformation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstrumentController : ControllerBase
    {
        private readonly IInstrumentService _instrumentService;
        public InstrumentController(IInstrumentService instrumentService)
        {
            _instrumentService = instrumentService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Instrument>>>> GetInstruments()
        {
            var result = await _instrumentService.GetAllInstruments();
            return Ok(result);
        }

        [HttpGet("SerialNumber/{serialNumber}")]
        public async Task<ActionResult<ServiceResponse<Instrument>>> GetInstrumentBySerialNumber(string serialNumber)
        {
            var result = await _instrumentService.GetInstrumentBySerialNumber(serialNumber);
            return Ok(result);
        }

      

        [HttpGet("GetInstruments/")]
        public async Task<ActionResult<ServiceResponse<List<Instrument>>>> GetInstrumentsByInstrumentType([FromQuery] string instrumentTypeName, [FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10)
        {
            var result = await _instrumentService.GetInstrumentsByInstrumentType(instrumentTypeName, pageNumber, pageSize);
            return Ok(result); 
        }
        [HttpPost("GetFilteredInstruments")]
        public async Task<IActionResult> GetFilteredInstruments(
            [FromBody] InstrumentQueryParams queryParams,
            [FromQuery] int pageNumber = 1,
            [FromQuery] int pageSize = 10)
        {
            PagedServiceResponse<List<Instrument>> result = await _instrumentService.GetInstrumentsByQueryParams(queryParams, pageNumber, pageSize);
            return Ok(result);
        }
    }
}
