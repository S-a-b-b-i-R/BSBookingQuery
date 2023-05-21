using BSBookingQuery.Domain.BusinessModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSBookingQuery.Domain.Abastractions
{
    public interface IGuestRepository
    {
        Task<IEnumerable<ViewGuest>> GetAll();
        Task<bool> Add(ViewGuest guest);
        Task<bool> Update(ViewGuest guest);
        Task<bool> Delete(int id);
    }
}
