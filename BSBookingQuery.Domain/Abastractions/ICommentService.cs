using BSBookingQuery.Domain.BusinessModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSBookingQuery.Domain.Abastractions
{
    public interface ICommentService
    {
        Task<IEnumerable<ViewComment>> GetAll(int? hotelId);
        Task<bool> Add(ViewComment comment, int? id);
        Task<bool> Update(ViewComment comment);
        Task<bool> Delete(int id);
    }
}
