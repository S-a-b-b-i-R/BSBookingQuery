using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BSBookingQuery.Domain.BusinessModels
{
    public class ViewGuest
    {
        public int GuestId { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Address { get; set; }

        public int? City { get; set; }

        public string? PhoneNumber { get; set; }

        public string? Email { get; set; }

        //public virtual ICollection<CommentDetail> CommentDetails { get; set; } = new List<CommentDetail>();

        //public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }
}
