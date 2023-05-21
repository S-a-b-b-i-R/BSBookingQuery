using BSBookingQuery.Domain.BusinessModels;
using BSBookingQuery.Domain.Abastractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSBookingQuery.Service.Services
{
    public class CityService : ICityService
    {
        private readonly ICityRepository _cityRepository;
        public CityService(ICityRepository cityRepository)
        {
            this._cityRepository = cityRepository;
        }
        public async Task<bool> Add(ViewCity city)
        {
            return await _cityRepository.Add(city);
        }

        public async Task<IEnumerable<ViewCity>> GetAll()
        {
            return await _cityRepository.GetAll();
        }

        public async Task<bool> Update(ViewCity city)
        {
            return await _cityRepository.Update(city);
        }

        public async Task<bool> Delete(int id)
        {
            return await _cityRepository.Delete(id);
        }
    }
}
