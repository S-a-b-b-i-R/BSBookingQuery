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
    public class CommentController : ControllerBase
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService CommentService)
        {
            this._commentService = CommentService;
        }

        [HttpGet]
        public async Task<ActionResult<List<ViewComment>>> GetAll(int? hotelId)
        {
            try
            {
                var comments = await this._commentService.GetAll(hotelId);
                if (comments == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(comments);
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                "Error retrieving data from the database");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Add(ViewComment comment, int? id)
        {
            var result = await this._commentService.Add(comment, id);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update(ViewComment comment)
        {
            var result = await this._commentService.Update(comment);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await this._commentService.Delete(id);
            return Ok(result);
        }
    }
}
