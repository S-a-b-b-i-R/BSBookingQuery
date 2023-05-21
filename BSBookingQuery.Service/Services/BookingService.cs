using BSBookingQuery.Domain.BusinessModels;
using BSBookingQuery.Domain.Abastractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSBookingQuery.Service.Services
{
    public class BookingService : IBookingService
    {
        private readonly IBookingRepository _bookingRepository;

        public BookingService(IBookingRepository bookingRepository)
        {
            this._bookingRepository = bookingRepository;
        }
        public async Task<bool> Add(ViewBooking booking)
        {
            return await _bookingRepository.Add(booking);
        }

        public async Task<IEnumerable<ViewBooking>> GetAll()
        {
            return await _bookingRepository.GetAll();
        }

        public async Task<bool> Update(ViewBooking booking)
        {
            return await _bookingRepository.Update(booking);
        }

        public async Task<bool> Delete(int id)
        {
            return await _bookingRepository.Delete(id);
        }
    }
}
