using BSBookingQuery.Domain.BusinessModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSBookingQuery.Domain.Abastractions
{
    public interface IRoomRepository
    {
        Task<IEnumerable<ViewRoom>> GetAll();
        Task<bool> Add(ViewRoom room);
        Task<bool> Update(ViewRoom room);
        Task<bool> Delete(int id);
    }
}
