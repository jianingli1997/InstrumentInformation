using InstrumentInformation.Models.DTOs.EntityDTO.InstrumentDTO;
using InstrumentInformation.Models.DTOs.QueryDTO;
using InstrumentInformation.Models.Entity.Instrument;
using InstrumentInformation.Models.Responses;
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
            ServiceResponse<List<Instrument>> result = await _instrumentService.GetAllInstruments();
            return Ok(result);
        }

        [HttpGet("{serialNumber}")]
        public async Task<ActionResult<ServiceResponse<Instrument>>> GetInstrumentBySerialNumber(string serialNumber)
        {
            ServiceResponse<Instrument> result = await _instrumentService.GetInstrumentBySerialNumber(serialNumber);
            return Ok(result);
        }


        [HttpGet("get-instruments/")]
        public async Task<ActionResult<ServiceResponse<List<Instrument>>>> GetInstrumentsByInstrumentType(
            [FromQuery] string instrumentTypeName, [FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10)
        {
            var result =
                await _instrumentService.GetInstrumentsByInstrumentType(instrumentTypeName, pageNumber, pageSize);
            return Ok(result);
        }

        [HttpPost("get-filtered-instruments")]
        public async Task<IActionResult> GetFilteredInstruments(
            [FromBody] InstrumentQueryParams queryParams,
            [FromQuery] int pageNumber = 1,
            [FromQuery] int pageSize = 10)
        {
            PagedServiceResponse<List<Instrument>> result =
                await _instrumentService.GetInstrumentsByQueryParams(queryParams, pageNumber, pageSize);
            return Ok(result);
        }

        [HttpPost("add-instrument")]
        public async Task<ActionResult<ServiceResponse<bool>>> AddInstrument([FromBody] InstrumentDTO instrumentDto)
        {
            ServiceResponse<bool> result = await _instrumentService.AddInstrument(instrumentDto);
            return Ok(result);
        }


        [HttpPut("update-instrument")]
        public async Task<ActionResult<ServiceResponse<InstrumentDTO>>> UpdateInstrument(
            [FromBody] InstrumentDTO instrumentDto)
        {
            ServiceResponse<InstrumentDTO> result = await _instrumentService.UpdateInstrument(instrumentDto);
            return Ok(result);
        }

        [HttpDelete("delete-instrument/{instrumentId}")]
        public async Task<ActionResult<ServiceResponse<bool>>>  DeleteInstrument(int instrumentId)
        {
            ServiceResponse<bool> result = await _instrumentService.DeleteInstrument(instrumentId);
            return Ok(result);
        }

    }
}