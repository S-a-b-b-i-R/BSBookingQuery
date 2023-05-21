using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSBookingQuery.Domain.BusinessModels
{
    public class ViewStaff
    {
        public int StaffId { get; set; }

        public int? HotelId { get; set; }

        public int? PositionId { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Address { get; set; }

        public int? City { get; set; }

        public int? Country { get; set; }

        public string? Phone { get; set; }

        public string? Email { get; set; }

        public DateTime? JoinDate { get; set; }

        public DateTime? ResignDate { get; set; }

        //public virtual City? CityNavigation { get; set; }

        //public virtual ICollection<CommentDetail> CommentDetails { get; set; } = new List<CommentDetail>();

        //public virtual Hotel? Hotel { get; set; }

        //public virtual Position? Position { get; set; }
    }
}
