using BSBookingQuery.Domain.BusinessModels;
using BSBookingQuery.Domain.Abastractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSBookingQuery.Service.Services
{
    public class CountryService : ICountryService
    {
        private readonly ICountryRepository _countryRepository;

        public CountryService(ICountryRepository countryRepository)
        {
            this._countryRepository = countryRepository;
        }

        public async Task<bool> Add(ViewCountry country)
        {
            return await _countryRepository.Add(country);
        }

        public async Task<IEnumerable<ViewCountry>> GetAll()
        {
            return await _countryRepository.GetAll();
        }
        public async Task<bool> Update(ViewCountry country)
        {
            return await _countryRepository.Update(country);
        }

        public async Task<bool> Delete(int id)
        {
            return await _countryRepository.Delete(id);
        }

    }
}
