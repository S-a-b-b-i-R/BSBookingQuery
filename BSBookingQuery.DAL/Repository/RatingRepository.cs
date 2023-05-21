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
    public class RatingRepository : IRatingRepository
    {
        public UnitOfWork unitOfWork = new UnitOfWork();

        public async Task<IEnumerable<ViewRating>> GetAll()
        {
            try
            {
                var result = unitOfWork.RatingRepository.Get();
                var ratingList = result.Select(item => new ViewRating { 
                    RatingId = item.RatingId, 
                    Value = item.Value });
                return ratingList;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<bool> Add(ViewRating rating)
        {
            try
            {
                unitOfWork.RatingRepository.Insert(new Rating { Value = rating.Value });
                unitOfWork.Save();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public async Task<bool> Update(ViewRating rating)
        {
            try
            {
                var model = new Rating {
                    RatingId = rating.RatingId, 
                    Value = rating.Value };
                unitOfWork.RatingRepository.Update(model);
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
                unitOfWork.RatingRepository.Delete(id);
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
