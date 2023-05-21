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
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService;
        public RoomController(IRoomService roomSerive)
        {
            this._roomService = roomSerive;
        }


        [HttpGet]
        public async Task<ActionResult<List<ViewRoom>>> GetAll()
        {
            try
            {
                var rooms = await this._roomService.GetAll();
                if (rooms == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(rooms);
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                "Error retrieving data from the database");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Add(ViewRoom room)
        {
            var result = await this._roomService.Add(room);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update(ViewRoom room)
        {
            var result = await this._roomService.Update(room);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await this._roomService.Delete(id);
            return Ok(result);
        }
    }
}
