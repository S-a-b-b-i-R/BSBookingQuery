using System;
using System.Collections.Generic;

namespace BSBookingQuery.DAL.Entities;

public partial class BookingStatus
{
    public int BookingStatusId { get; set; }

    public string? Description { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<BookingDetail> BookingDetails { get; set; } = new List<BookingDetail>();
}
