using System;
using System.Collections.Generic;

namespace BSBookingQuery.DAL.Entities;

public partial class Rating
{
    public int RatingId { get; set; }

    public int? Value { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public virtual ICollection<Hotel> Hotels { get; set; } = new List<Hotel>();
}
