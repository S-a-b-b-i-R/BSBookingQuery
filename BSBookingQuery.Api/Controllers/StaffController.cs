using BSBookingQuery.Domain.Abastractions;
using BSBookingQuery.Domain.BusinessModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BSBookingQuery.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly IStaffService _staffService;

        public StaffController(IStaffService staffService)
        {
            this._staffService = staffService;
        }

        [HttpGet]
        public async Task<ActionResult<List<ViewStaff>>> GetAll()
        {
            try
            {
                var staffs = await this._staffService.GetAll();
                if (staffs == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(staffs);
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                "Error retrieving data from the database");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Add(ViewStaff staff)
        {
            var result = await this._staffService.Add(staff);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update(ViewStaff staff)
        {
            var result = await this._staffService.Update(staff);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await this._staffService.Delete(id);
            return Ok(result);
        }
    }
}
