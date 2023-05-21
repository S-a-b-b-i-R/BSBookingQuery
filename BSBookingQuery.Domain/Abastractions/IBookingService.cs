using BSBookingQuery.Domain.BusinessModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSBookingQuery.Domain.Abastractions
{
    public interface IBookingService
    {
        Task<IEnumerable<ViewBooking>> GetAll();
        Task<bool> Add(ViewBooking booking);
        Task<bool> Update(ViewBooking booking);
        Task<bool> Delete(int id);
    }
}
