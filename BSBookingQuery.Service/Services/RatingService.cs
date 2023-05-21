using BSBookingQuery.Domain.Abastractions;
using BSBookingQuery.Domain.BusinessModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSBookingQuery.Service.Services
{
    public class RatingService : IRatingService
    {
        private readonly IRatingRepository _ratingRepository;

        public RatingService(IRatingRepository ratingRepository)
        {
            this._ratingRepository = ratingRepository;
        }

        public async Task<bool> Add(ViewRating rating)
        {
            return await _ratingRepository.Add(rating);
        }

        public async Task<IEnumerable<ViewRating>> GetAll()
        {
            return await _ratingRepository.GetAll();
        }

        public async Task<bool> Update(ViewRating rating)
        {
            return await _ratingRepository.Update(rating);
        }

        public async Task<bool> Delete(int id)
        {
            return await _ratingRepository.Delete(id);
        }
    }
}
