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
    public class RoomTypeController : ControllerBase
    {
        private readonly IRoomTypeService _roomTypeService;
        public RoomTypeController(IRoomTypeService roomTypeSerive)
        {
            this._roomTypeService = roomTypeSerive;
        }

        [HttpGet]
        public async Task<ActionResult<List<ViewRoomType>>> GetAll()
        {
            try
            {
                var roomTypes = await this._roomTypeService.GetAll();
                if (roomTypes == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(roomTypes);
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                "Error retrieving data from the database");
            }
        }
        [HttpPost]
        public async Task<IActionResult> Add(ViewRoomType roomType)
        {
            var result = await this._roomTypeService.Add(roomType);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update(ViewRoomType roomType)
        {
            var result = await this._roomTypeService.Update(roomType);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await this._roomTypeService.Delete(id);
            return Ok(result);
        }

    }
}
