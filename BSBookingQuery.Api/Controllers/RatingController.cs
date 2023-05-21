using BSBookingQuery.Domain.BusinessModels;
using BSBookingQuery.Domain.Abastractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System.Security.AccessControl;

namespace BSBookingQuery.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatingController : ControllerBase
    {
        private readonly IRatingService _ratingService;
        public RatingController(IRatingService ratingSerive)
        {
            this._ratingService = ratingSerive;
        }

        [HttpGet]
        public async Task<ActionResult<List<ViewRating>>> GetAll()
        {
            try
            {
                var ratings = await this._ratingService.GetAll();
                if (ratings == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(ratings);
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                "Error retrieving data from the database");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Add(ViewRating rating)
        {
            var result = await this._ratingService.Add(rating);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update(ViewRating rating)
        {
            var result = await this._ratingService.Update(rating);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await this._ratingService.Delete(id);
            return Ok(result);
        }
    }
}
