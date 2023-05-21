using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSBookingQuery.Domain.BusinessModels
{
    public class ViewRoom
    {
        public int RoomId { get; set; }

        public int? HotelId { get; set; }

        public int? RoomTypeId { get; set; }

        public string? RoomNumber { get; set; }

        public string? Description { get; set; }

        public bool? RoomStatus { get; set; }

        //public virtual ICollection<BookingDetail> BookingDetails { get; set; } = new List<BookingDetail>();

        //public virtual Hotel? Hotel { get; set; }

        //public virtual RoomType? RoomType { get; set; }
    }
}
