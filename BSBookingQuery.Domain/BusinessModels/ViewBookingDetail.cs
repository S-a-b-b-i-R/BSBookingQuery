using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSBookingQuery.Domain.BusinessModels
{
    public class ViewBookingDetail
    {
        public int BookingDetailId { get; set; }

        public int? BookingId { get; set; }

        public int? RoomId { get; set; }

        public DateTime? DateFrom { get; set; }

        public DateTime? DateTo { get; set; }

        public bool? IsActive { get; set; }

        public int? BookingStatusId { get; set; }

    }
}
