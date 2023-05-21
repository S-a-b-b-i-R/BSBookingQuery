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
    public class RoomTypeRepository : IRoomTypeRepository
    {
        public UnitOfWork unitOfWork = new UnitOfWork();

        public async Task<IEnumerable<ViewRoomType>> GetAll()
        {
            try
            {
                var result = unitOfWork.RoomTypeRepository.Get();
                var roomTypeList = result.Select(item => new ViewRoomType { 
                    RoomTypeId = item.RoomTypeId, 
                    RoomDetail = item.RoomDetail, 
                    Description = item.Description,
                    NumberOfRooms = item.NumberOfRooms, 
                    IsActive = item.IsActive });
                return roomTypeList;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<bool> Add(ViewRoomType roomType)
        {
            try
            {
                unitOfWork.RoomTypeRepository.Insert(new RoomType { 
                    RoomDetail= roomType.RoomDetail,
                    Description = roomType.Description, 
                    NumberOfRooms = roomType.NumberOfRooms, 
                    IsActive = roomType.IsActive  });
                unitOfWork.Save();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> Update(ViewRoomType roomType)
        {
            try
            {
                var model = new RoomType { 
                    RoomTypeId = roomType.RoomTypeId, 
                    RoomDetail = roomType.RoomDetail,
                    Description = roomType.Description,
                    NumberOfRooms = roomType.NumberOfRooms, 
                    IsActive = roomType.IsActive };
                unitOfWork.RoomTypeRepository.Update(model);
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
                unitOfWork.RoomTypeRepository.Delete(id);
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
