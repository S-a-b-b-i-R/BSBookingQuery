using System;
using System.Collections.Generic;

namespace BSBookingQuery.DAL.Entities;

public partial class Staff
{
    public int StaffId { get; set; }

    public int? HotelId { get; set; }

    public int? PositionId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Address { get; set; }

    public int? City { get; set; }

    public int? Country { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public DateTime? JoinDate { get; set; }

    public DateTime? ResignDate { get; set; }

    public virtual City? CityNavigation { get; set; }

    public virtual Hotel? Hotel { get; set; }

    public virtual Position? Position { get; set; }
}
