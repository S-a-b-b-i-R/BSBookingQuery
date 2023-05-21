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
    public class GuestController : ControllerBase
    {
        private readonly IGuestService _guestService;

        public GuestController(IGuestService GuestService)
        {
            this._guestService = GuestService;
        }

        [HttpGet]
        public async Task<ActionResult<List<ViewGuest>>> GetAll()
        {
            try
            {
                var guests = await this._guestService.GetAll();
                if (guests == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(guests);
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                "Error retrieving data from the database");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Add(ViewGuest guest)
        {
            var result = await this._guestService.Add(guest);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update(ViewGuest guest)
        {
            var result = await this._guestService.Update(guest);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await this._guestService.Delete(id);
            return Ok(result);
        }
    }
}
