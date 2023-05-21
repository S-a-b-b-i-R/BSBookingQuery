using BSBookingQuery.Domain.Abastractions;
using BSBookingQuery.Domain.BusinessModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSBookingQuery.Service.Services
{
    public class GuestService : IGuestService
    {
        private readonly IGuestRepository _guestRepository;

        public GuestService(IGuestRepository guestRepository)
        {
            this._guestRepository = guestRepository;
        }

        public async Task<bool> Add(ViewGuest guest)
        {
            return await _guestRepository.Add(guest);
        }

        public async Task<IEnumerable<ViewGuest>> GetAll()
        {
            return await _guestRepository.GetAll();
        }

        public async Task<bool> Update(ViewGuest guest)
        {
            return await _guestRepository.Update(guest);
        }

        public async Task<bool> Delete(int id)
        {
            return await _guestRepository.Delete(id);
        }
    }
}
