using BSBookingQuery.Domain.Abastractions;
using BSBookingQuery.Domain.BusinessModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSBookingQuery.Service.Services
{
    public class StaffService : IStaffService
    {
        private readonly IStaffRepository _staffRepository;

        public StaffService(IStaffRepository staffRepository)
        {
            this._staffRepository = staffRepository;
        }

        public async Task<bool> Add(ViewStaff staff)
        {
            return await _staffRepository.Add(staff);
        }

        public async Task<IEnumerable<ViewStaff>> GetAll()
        {
            return await _staffRepository.GetAll();
        }
        public async Task<bool> Update(ViewStaff staff)
        {
            return await _staffRepository.Update(staff);
        }

        public async Task<bool> Delete(int id)
        {
            return await _staffRepository.Delete(id);
        }

    }
}
