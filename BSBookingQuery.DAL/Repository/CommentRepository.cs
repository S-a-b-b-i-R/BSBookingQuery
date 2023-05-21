using BSBookingQuery.DAL.Entities;
using BSBookingQuery.DAL.UnitOfWorks;
using BSBookingQuery.Domain.Abastractions;
using BSBookingQuery.Domain.BusinessModels;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BSBookingQuery.DAL.Repository
{
    public class CommentRepository : ICommentRepository
    {
        public UnitOfWork unitOfWork = new UnitOfWork();

        public async Task<IEnumerable<ViewComment>> GetAll(int? hotelId)
        {
            try
            {
                var result = unitOfWork.CommentRepository.Get().Where(x => x.HotelId == hotelId);
                var commentList = result.Select(item => new ViewComment
                {
                    CommentId = item.CommentId,
                    Description = item.Description,
                    GuestId = item.GuestId,
                    CommentTime = item.CommentTime,
                    HotelId = item.HotelId,
                    IsDeleted = item.IsDeleted,
                    UserReview = item.UserReview,
                    ParentKey = item.ParentKey
                });
                var rootComment = commentList.Where(x => x.ParentKey == null).ToList();
                var replyComment = commentList.Where(x => x.ParentKey != null).ToList();
                foreach (var comment in rootComment)
                {
                    commentReplies(comment, replyComment);
                };
                
                return rootComment;
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        private void commentReplies(ViewComment parentComment, List<ViewComment> comments)
        {
            List<ViewComment> replies = comments.Where(c => c.ParentKey == parentComment.CommentId).ToList();
            if (replies.Count > 0)
            {
                parentComment.Replies = replies;
                foreach (ViewComment reply in replies)
                {
                    commentReplies(reply, comments);
                }
            }
        }

        public async Task<bool> Add(ViewComment comment, int? id)
        {
            try
            {
                if (id == null)
                {
                    unitOfWork.CommentRepository.Insert(new Comment
                    {
                        Description = comment.Description,
                        GuestId = comment.GuestId == 0 ? null : comment.GuestId,
                        StaffId = comment.StaffId == 0 ? null : comment.StaffId,
                        CommentTime = DateTime.Now,
                        HotelId = comment.HotelId,
                        IsDeleted = comment.IsDeleted,
                        UserReview = comment.UserReview
                    });
                    unitOfWork.Save();
                    return true;
                }
                else
                {
                    unitOfWork.CommentRepository.Insert(new Comment
                    {
                        Description = comment.Description,
                        GuestId = comment.GuestId == 0 ? null : comment.GuestId,
                        StaffId = comment.StaffId == 0 ? null : comment.StaffId,
                        CommentTime = DateTime.Now,
                        HotelId = comment.HotelId,
                        IsDeleted = comment.IsDeleted,
                        UserReview = comment.UserReview,
                        ParentKey = id
                    });
                    unitOfWork.Save();
                    return true;
                }

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> Update(ViewComment comment)
        {
            try
            {
                var model = new Comment
                {
                    CommentId = comment.CommentId,
                    Description = comment.Description,
                    GuestId = comment.GuestId,
                    StaffId = comment.StaffId,
                    CommentTime = comment.CommentTime,
                    HotelId = comment.HotelId,
                    IsDeleted = comment.IsDeleted,
                    UserReview = comment.UserReview,
                    ParentKey = comment.ParentKey
                };
                unitOfWork.CommentRepository.Update(model);
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
                unitOfWork.CommentRepository.Delete(id);
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
