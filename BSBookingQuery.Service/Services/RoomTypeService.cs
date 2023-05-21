using BSBookingQuery.Domain.Abastractions;
using BSBookingQuery.Domain.BusinessModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSBookingQuery.Service.Services
{
    public class RoomTypeService : IRoomTypeService
    {
        private readonly IRoomTypeRepository _roomTypeRepository;

        public RoomTypeService(IRoomTypeRepository roomTypeRepository)
        {
            this._roomTypeRepository = roomTypeRepository;
        }
        public async Task<bool> Add(ViewRoomType roomType)
        {
            return await _roomTypeRepository.Add(roomType);
        }

        public async Task<IEnumerable<ViewRoomType>> GetAll()
        {
            return await _roomTypeRepository.GetAll();
        }
        public async Task<bool> Update(ViewRoomType roomType)
        {
            return await _roomTypeRepository.Update(roomType);
        }

        public async Task<bool> Delete(int id)
        {
            return await _roomTypeRepository.Delete(id);
        }

    }
}
