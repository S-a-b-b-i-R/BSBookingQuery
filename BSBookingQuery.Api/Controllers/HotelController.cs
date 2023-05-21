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
    public class HotelController : ControllerBase
    {
        private readonly IHotelSerive _hotelService;
        public HotelController(IHotelSerive hotelSerive)
        {
            this._hotelService = hotelSerive;
        }


        [HttpGet]
        public async Task<ActionResult<List<ViewHotel>>> GetAll()
        {
            try
            {
                var hotels = await this._hotelService.GetAll();
                if (hotels == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(hotels);
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                "Error retrieving data from the database");
            }
        }

        [HttpGet("FilterHotels")]
        public async Task<ActionResult<List<ViewHotel>>> FilterHotels(string? name, int? city, int? rating)
        {
            try
            {
                var hotels = await this._hotelService.FilterHotels(name, city, rating);
                if (hotels == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(hotels);
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                "Error retrieving data from the database");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Add(ViewHotel hotel)
        {
            var result = await this._hotelService.Add(hotel);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update(ViewHotel hotel)
        {
            var result = await this._hotelService.Update(hotel);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await this._hotelService.Delete(id);
            return Ok(result);
        }
    }
}
