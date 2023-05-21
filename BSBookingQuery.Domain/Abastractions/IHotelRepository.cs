using BSBookingQuery.Domain.BusinessModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSBookingQuery.Domain.Abastractions
{
    public interface IHotelRepository
    {
        Task<IEnumerable<ViewHotel>> GetAll();
        Task<bool> Add(ViewHotel hotel);
        Task<bool> Update(ViewHotel hotel);
        Task<bool> Delete(int id);
        Task<IEnumerable<ViewHotel>> FilterHotels(string? name, int? city, int? rating);
    }
}
