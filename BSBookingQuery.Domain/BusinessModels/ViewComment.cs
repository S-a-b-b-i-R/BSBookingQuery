using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BSBookingQuery.Domain.BusinessModels
{
    public class ViewComment
    {

        public ViewComment()
        {
            this.Replies  = new List<ViewComment>();
        }
        public int CommentId { get; set; }

        public string? Description { get; set; }

        public int? GuestId { get; set; }

        public int? StaffId { get; set; }

        public DateTime? CommentTime { get; set; }

        public int? HotelId { get; set; }

        public bool? IsDeleted { get; set; }

        public int? UserReview { get; set; }

        public int? ParentKey { get; set; }

        public List<ViewComment> Replies { get; set; }

        //public virtual ICollection<CommentDetail> CommentDetails { get; set; } = new List<CommentDetail>();

        //public virtual Guest? Guest { get; set; }

        //public virtual Hotel? Hotel { get; set; }

        //public virtual Rating? Rating { get; set; }
    }
}
