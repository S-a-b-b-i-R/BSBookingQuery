using System;
using System.Collections.Generic;

namespace BSBookingQuery.DAL.Entities;

public partial class Country
{
    public int CountryId { get; set; }

    public string? Name { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<City> Cities { get; set; } = new List<City>();
}
