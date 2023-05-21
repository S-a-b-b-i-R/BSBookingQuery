using System;
using System.Collections.Generic;

namespace BSBookingQuery.DAL.Entities;

public partial class BookingDetail
{
    public int BookingDetailId { get; set; }

    public int? BookingId { get; set; }

    public int? RoomId { get; set; }

    public DateTime? DateFrom { get; set; }

    public DateTime? DateTo { get; set; }

    public bool? IsActive { get; set; }

    public int? BookingStatusId { get; set; }

    public virtual Booking? Booking { get; set; }

    public virtual BookingStatus? BookingStatus { get; set; }

    public virtual Room? Room { get; set; }
}
