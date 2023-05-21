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
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService BookingService)
        {
            this._bookingService = BookingService;
        }

        [HttpGet]
        public async Task<ActionResult<List<ViewBooking>>> GetAll()
        {
            try
            {
                var bookings = await this._bookingService.GetAll();
                if (bookings == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(bookings);
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                "Error retrieving data from the database");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Add(ViewBooking booking)
        {
            var result = await this._bookingService.Add(booking);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update(ViewBooking booking)
        {
            var result = await this._bookingService.Update(booking);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await this._bookingService.Delete(id);
            return Ok(result);
        }
    }
}
