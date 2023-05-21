using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSBookingQuery.Domain.BusinessModels
{
    public class ViewBooking
    {
        
        public ViewBooking()
        { 
            this.BookingDetails  = new List<ViewBookingDetail>();
        }
        public int BookingId { get; set; }

        public int? HotelId { get; set; }

        public int? GuestId { get; set; }

        public bool? IsActive { get; set; }
        public  List<ViewBookingDetail> BookingDetails { get; set; } 
    }
}
