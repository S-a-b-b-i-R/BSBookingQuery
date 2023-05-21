using BSBookingQuery.Domain.BusinessModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BSBookingQuery.Domain.Abastractions
{
    public interface IStaffService
    {
        Task<IEnumerable<ViewStaff>> GetAll();
        Task<bool> Add(ViewStaff staff);
        Task<bool> Update(ViewStaff staff);
        Task<bool> Delete(int id);
    }
}
