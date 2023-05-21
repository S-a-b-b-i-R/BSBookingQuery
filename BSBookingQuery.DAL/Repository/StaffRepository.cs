using BSBookingQuery.DAL.Entities;
using BSBookingQuery.DAL.UnitOfWorks;
using BSBookingQuery.Domain.Abastractions;
using BSBookingQuery.Domain.BusinessModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSBookingQuery.DAL.Repository
{
    public class StaffRepository : IStaffRepository
    {
        public UnitOfWork unitOfWork = new UnitOfWork();

        public async Task<IEnumerable<ViewStaff>> GetAll()
        {
            try
            {
                var result = unitOfWork.StaffRepository.Get();
                var staffList = result.Select(item => new ViewStaff { 
                    StaffId = item.StaffId, 
                    HotelId = item.HotelId, 
                    PositionId = item.PositionId, 
                    FirstName = item.FirstName, 
                    LastName = item.LastName, 
                    Address = item.Address,
                    City = item.City, 
                    Phone = item.Phone, 
                    Email = item.Email, 
                    JoinDate = item.JoinDate, 
                    ResignDate = item.ResignDate });
                return staffList;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<bool> Add(ViewStaff staff)
        {
            try
            {
                var model = new Staff { 
                    HotelId = staff.HotelId, 
                    PositionId = staff.PositionId, 
                    FirstName = staff.FirstName, 
                    LastName = staff.LastName, 
                    Address = staff.Address, 
                    City = staff.City, 
                    Country = staff.Country, 
                    Phone = staff.Phone, 
                    Email = staff.Email, 
                    JoinDate = staff.JoinDate, 
                    ResignDate = staff.ResignDate };
                unitOfWork.StaffRepository.Insert(model);
                unitOfWork.Save();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> Update(ViewStaff staff)
        {
            try
            {
                var model = new Staff { 
                    StaffId = staff.StaffId, 
                    HotelId = staff.HotelId, 
                    PositionId = staff.PositionId, 
                    FirstName = staff.FirstName, 
                    LastName = staff.LastName, 
                    Address = staff.Address,
                    City = staff.City, 
                    Phone = staff.Phone,
                    Email = staff.Email,
                    JoinDate = staff.JoinDate, 
                    ResignDate = staff.ResignDate };
                unitOfWork.StaffRepository.Update(model);
                unitOfWork.Save();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public async Task<bool> Delete(int id)
        {
            try
            {
                unitOfWork.StaffRepository.Delete(id);
                unitOfWork.Save();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
