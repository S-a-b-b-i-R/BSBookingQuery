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
    public class GuestRepository : IGuestRepository
    {
        public UnitOfWork unitOfWork = new UnitOfWork();

        public async Task<IEnumerable<ViewGuest>> GetAll()
        {
            try
            {
                var result = unitOfWork.GuestRepository.Get();
                var guestList = result.Select(item => new ViewGuest { 
                    GuestId = item.GuestId, 
                    FirstName = item.FirstName, 
                    LastName = item.LastName, 
                    Address = item.Address, 
                    City = item.City,  
                    PhoneNumber = item.PhoneNumber, 
                    Email = item.Email  });
                return guestList;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<bool> Add(ViewGuest guest)
        {
            try
            {
                unitOfWork.GuestRepository.Insert(new Guest { 
                    FirstName = guest.FirstName, 
                    LastName = guest.LastName, 
                    Address = guest.Address, 
                    City = guest.City,  
                    PhoneNumber = guest.PhoneNumber, 
                    Email = guest.Email });
                unitOfWork.Save();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> Update(ViewGuest guest)
        {
            try
            {
                var model = new Guest { 
                    GuestId = guest.GuestId, 
                    FirstName = guest.FirstName, 
                    LastName = guest.LastName, 
                    Address = guest.Address, 
                    City = guest.City, 
                    PhoneNumber = guest.PhoneNumber,
                    Email = guest.Email };
                unitOfWork.GuestRepository.Update(model);
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

                unitOfWork.GuestRepository.Delete(id);
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
