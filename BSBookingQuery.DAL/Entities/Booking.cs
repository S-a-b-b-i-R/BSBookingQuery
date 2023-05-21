using System;
using System.Collections.Generic;

namespace BSBookingQuery.DAL.Entities;

public partial class Booking
{
    public int BookingId { get; set; }

    public int? HotelId { get; set; }

    public int? GuestId { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<BookingDetail> BookingDetails { get; set; } = new List<BookingDetail>();
}
