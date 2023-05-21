using BSBookingQuery.Domain.BusinessModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSBookingQuery.Domain.Abastractions
{
    public interface IRoomTypeService
    {
        Task<IEnumerable<ViewRoomType>> GetAll();
        Task<bool> Add(ViewRoomType roomType);
        Task<bool> Update(ViewRoomType roomType);
        Task<bool> Delete(int id);
    }
}
