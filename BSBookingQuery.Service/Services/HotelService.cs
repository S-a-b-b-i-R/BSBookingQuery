using BSBookingQuery.Domain.Abastractions;
using BSBookingQuery.Domain.BusinessModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSBookingQuery.Service.Services
{
    public class HotelService : IHotelSerive
    {
        private readonly IHotelRepository _hotelRepository;
        public HotelService(IHotelRepository hotelRepository)
        {
            this._hotelRepository = hotelRepository;
        }
        public async Task<IEnumerable<ViewHotel>> GetAll()
        {
            return await _hotelRepository.GetAll();
        }

        public async Task<bool> Add(ViewHotel hotel)
        {
            return await _hotelRepository.Add(hotel);
        }
        public async Task<bool> Update(ViewHotel hotel)
        {
            return await _hotelRepository.Update(hotel);
        }

        public async Task<bool> Delete(int id)
        {
            return await _hotelRepository.Delete(id);
        }

        public async Task<IEnumerable<ViewHotel>> FilterHotels(string? name, int? city, int? rating)
        {
            return await _hotelRepository.FilterHotels(name, city, rating);
        }
    }
}
