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
    public class CountryController : ControllerBase
    {
        private readonly ICountryService _countryService;

        public CountryController(ICountryService CountryService)
        {
            this._countryService = CountryService;
        }

        [HttpGet]
        public async Task<ActionResult<List<ViewCountry>>> GetAll()
        {
            try
            {
                var countries = await this._countryService.GetAll();
                if (countries == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(countries);
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                "Error retrieving data from the database");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Add(ViewCountry country)
        {
            var result = await this._countryService.Add(country);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update(ViewCountry country)
        {
            var result = await this._countryService.Update(country);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await this._countryService.Delete(id);
            return Ok(result);
        }
    }
}
