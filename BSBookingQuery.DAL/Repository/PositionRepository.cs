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
    public class PositionRepository : IPositionRepository
    {
        public UnitOfWork unitOfWork = new UnitOfWork();

        public async Task<IEnumerable<ViewPosition>> GetAll()
        {
            try
            {
                var result = unitOfWork.PositionRepository.Get();
                var positionList = result.Select(item => new ViewPosition { 
                    PositionId = item.PositionId, 
                    Name = item.Name,
                    IsActive = item.IsActive,
                    IsAdmin = item.IsAdmin });
                return positionList;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<bool> Add(ViewPosition position)
        {
            try
            {
                unitOfWork.PositionRepository.Insert(new Position { 
                    Name = position.Name, 
                    IsActive = position.IsActive,
                    IsAdmin = position.IsAdmin });
                unitOfWork.Save();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> Update(ViewPosition position)
        {
            try
            {
                var model = new Position { 
                    PositionId = position.PositionId,
                    Name = position.Name, 
                    IsActive = position.IsActive,
                    IsAdmin = position.IsAdmin };
                unitOfWork.PositionRepository.Update(model);
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

                unitOfWork.PositionRepository.Delete(id);
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
