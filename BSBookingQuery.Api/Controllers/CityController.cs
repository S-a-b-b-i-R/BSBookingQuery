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
    public class CityController : ControllerBase
    {
        private readonly ICityService _cityService;
        public CityController(ICityService citySerive)
        {
            this._cityService = citySerive;
        }


        [HttpGet]
        public async Task<ActionResult<List<ViewCity>>> GetAll()
        {
            try
            {
                var cities = await this._cityService.GetAll();
                if (cities == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(cities);
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                "Error retrieving data from the database");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Add(ViewCity city)
        {
            var result = await this._cityService.Add(city);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update(ViewCity city)
        {
            var result = await this._cityService.Update(city);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await this._cityService.Delete(id);
            return Ok(result);
        }

    }
}
