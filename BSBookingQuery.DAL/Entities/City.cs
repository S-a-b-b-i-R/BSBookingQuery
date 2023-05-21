using System;
using System.Collections.Generic;

namespace BSBookingQuery.DAL.Entities;

public partial class City
{
    public int CityId { get; set; }

    public int? CountryId { get; set; }

    public string? Name { get; set; }

    public bool? IsActive { get; set; }

    public virtual Country? Country { get; set; }

    public virtual ICollection<Staff> Staff { get; set; } = new List<Staff>();
}
