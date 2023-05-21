using System;
using System.Collections.Generic;

namespace BSBookingQuery.DAL.Entities;

public partial class Guest
{
    public int GuestId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Address { get; set; }

    public int? City { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();
}
