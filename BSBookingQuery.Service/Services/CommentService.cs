using BSBookingQuery.Domain.BusinessModels;
using BSBookingQuery.Domain.Abastractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSBookingQuery.Service.Services
{
    public class CommentService : ICommentService
    {
        private readonly ICommentRepository _commentRepository;

        public CommentService(ICommentRepository commentRepository)
        {
            this._commentRepository = commentRepository;
        }

        public async Task<bool> Add(ViewComment comment, int? id)
        {
            return await _commentRepository.Add(comment, id);
        }

        public async Task<IEnumerable<ViewComment>> GetAll(int? hotelId)
        {
            return await _commentRepository.GetAll(hotelId);
        }
        public async Task<bool> Update(ViewComment comment)
        {
            return await _commentRepository.Update(comment);
        }
        public async Task<bool> Delete(int id)
        {
            return await _commentRepository.Delete(id);
        }

    }
}
