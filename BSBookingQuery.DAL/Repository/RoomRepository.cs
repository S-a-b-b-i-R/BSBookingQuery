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
    public class RoomRepository: IRoomRepository
    {
        private UnitOfWork unitOfWork = new UnitOfWork();

        public Task<IEnumerable<ViewRoom>> GetAll()
        {
            try
            {
                var result = unitOfWork.RoomRepository.Get();
                var roomList = result.Select(item => new ViewRoom { 
                    RoomId = item.RoomId, 
                    HotelId = item.HotelId, 
                    RoomTypeId = item.RoomTypeId, 
                    RoomNumber = item.RoomNumber, 
                    Description = item.Description, 
                    RoomStatus = item.RoomStatus });
                return (Task<IEnumerable<ViewRoom>>)roomList;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<bool> Add(ViewRoom room)
        {
            try
            {
                unitOfWork.RoomRepository.Insert(new Room { 
                    RoomTypeId = room.RoomTypeId, 
                    HotelId = room.HotelId, 
                    RoomNumber = room.RoomNumber,
                    Description = room.Description,
                    RoomStatus = room.RoomStatus });
                unitOfWork.Save();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> Update(ViewRoom room)
        {
            try
            {
                var model = new Room { 
                    RoomId = room.RoomId, 
                    HotelId = room.HotelId, 
                    RoomTypeId = room.RoomTypeId,
                    RoomNumber = room.RoomNumber, 
                    Description = room.Description, 
                    RoomStatus = room.RoomStatus };
                unitOfWork.RoomRepository.Update(model);
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
                unitOfWork.RoomRepository.Delete(id);
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
