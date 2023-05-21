using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSBookingQuery.Domain.BusinessModels
{
    public class ViewBookingStatus
    {
        public int BookingStatusId { get; set; }

        public string? Description { get; set; }

        public bool? IsActive { get; set; }

        //public virtual ICollection<BookingDetail> BookingDetails { get; set; } = new List<BookingDetail>();
    }
}
