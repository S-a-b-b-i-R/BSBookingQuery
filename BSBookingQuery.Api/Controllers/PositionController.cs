using BSBookingQuery.Domain.Abastractions;
using BSBookingQuery.Domain.BusinessModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BSBookingQuery.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PositionController : ControllerBase
    {
        private readonly IPositionService _positionService;

        public PositionController(IPositionService PositionService)
        {
            this._positionService = PositionService;
        }

        [HttpGet]
        public async Task<ActionResult<List<ViewPosition>>> GetAll()
        {
            try
            {
                var positions = await this._positionService.GetAll();
                if (positions == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(positions);
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                "Error retrieving data from the database");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Add(ViewPosition position)
        {
            var result = await this._positionService.Add(position);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update(ViewPosition position)
        {
            var result = await this._positionService.Update(position);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await this._positionService.Delete(id);
            return Ok(result);
        }
    }
}
