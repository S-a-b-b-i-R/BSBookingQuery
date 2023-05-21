using BSBookingQuery.Domain.BusinessModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSBookingQuery.Domain.Abastractions
{
    public interface IRatingService
    {
        Task<IEnumerable<ViewRating>> GetAll();
        Task<bool> Add(ViewRating rating);
        Task<bool> Update(ViewRating rating);
        Task<bool> Delete(int id);
    }
}
