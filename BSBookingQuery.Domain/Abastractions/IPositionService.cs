using BSBookingQuery.Domain.BusinessModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSBookingQuery.Domain.Abastractions
{
    public interface IPositionService
    {
        Task<IEnumerable<ViewPosition>> GetAll();
        Task<bool> Add(ViewPosition position);
        Task<bool> Update(ViewPosition position);
        Task<bool> Delete(int id);
    }
}
