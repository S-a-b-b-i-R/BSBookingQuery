using BSBookingQuery.Domain.BusinessModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSBookingQuery.Domain.Abastractions
{
    public interface ICityService
    {
        Task<IEnumerable<ViewCity>> GetAll();
        Task<bool> Add(ViewCity city);
        Task<bool> Update(ViewCity city);
        Task<bool> Delete(int id);
    }
}
