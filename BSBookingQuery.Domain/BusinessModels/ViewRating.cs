using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BSBookingQuery.Domain.BusinessModels
{
    public class ViewRating
    {
        public int RatingId { get; set; }

        public int? Value { get; set; }

        public string? Description { get; set; }

        //public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }
}
