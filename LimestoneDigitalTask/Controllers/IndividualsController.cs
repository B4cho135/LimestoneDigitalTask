using Application;
using Microsoft.AspNetCore.Mvc;

namespace LimestoneDigitalTask.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class IndividualsController : ControllerBase
    {
        private readonly IIndividualService _individualService;

        public IndividualsController(IIndividualService indvidiualService)
        {
            _individualService = indvidiualService;
        }

        [HttpGet("{nationalId}")]
        public async Task<IActionResult> SearchBy(string nationalId)
        {
            var individual = await _individualService.SearchByNationalId(nationalId);

            if(individual == null)
            {
                return Ok("no hit");
            }
            return Ok("single hit");
        }

        [HttpGet("{nationalId}/Details")]
        public async Task<IActionResult> GetDetailsBy(string nationalId)
        {
            var individualDetails = await _individualService.GetDetailsBy(nationalId);

            if (individualDetails == null)
            {
                return NotFound();
            }
            return Ok(individualDetails);
        }
    }
}
