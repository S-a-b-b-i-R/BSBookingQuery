using BSBookingQuery.Domain.BusinessModels;
using BSBookingQuery.Domain.Abastractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSBookingQuery.Service.Services
{
    public class RoomService: IRoomService
    {
        private readonly IRoomRepository _roomRepository;

        public RoomService(IRoomRepository roomRepository)
        {
            this._roomRepository = roomRepository;
        }
        public async Task<bool> Add(ViewRoom room)
        {
            return await _roomRepository.Add(room);
        }

        public async Task<IEnumerable<ViewRoom>> GetAll()
        {
            return await _roomRepository.GetAll();
        }

        public async Task<bool> Update(ViewRoom room)
        {
            return await _roomRepository.Update(room);
        }

        public async Task<bool> Delete(int id)
        {
            return await _roomRepository.Delete(id);
        }
    }
}
