using System;
using System.Collections.Generic;

namespace BSBookingQuery.DAL.Entities;

public partial class Position
{
    public int PositionId { get; set; }

    public string? Name { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsAdmin { get; set; }

    public virtual ICollection<Staff> Staff { get; set; } = new List<Staff>();
}
