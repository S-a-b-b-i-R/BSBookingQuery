using BSBookingQuery.Domain.Abastractions;
using BSBookingQuery.Domain.BusinessModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSBookingQuery.Service.Services
{
    public class PositionService : IPositionService
    {
        private readonly IPositionRepository _positionRepository;

        public PositionService(IPositionRepository positionRepository)
        {
            this._positionRepository = positionRepository;
        }

        public async Task<bool> Add(ViewPosition position)
        {
            return await _positionRepository.Add(position);
        }

        public async Task<IEnumerable<ViewPosition>> GetAll()
        {
            return await _positionRepository.GetAll();
        }

        public async Task<bool> Update(ViewPosition position)
        {
            return await _positionRepository.Update(position);
        }

        public async Task<bool> Delete(int id)
        {
            return await _positionRepository.Delete(id);
        }
    }
}
