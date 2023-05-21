using System;
using System.Collections.Generic;

namespace BSBookingQuery.DAL.Entities;

public partial class Hotel
{
    public int HotelId { get; set; }

    public string? HotelCode { get; set; }

    public string? Name { get; set; }

    public string? Address { get; set; }

    public int? City { get; set; }

    public string? Phone { get; set; }

    public string? Website { get; set; }

    public string? ImagePath { get; set; }

    public int? RatingId { get; set; }

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public virtual Rating? Rating { get; set; }

    public virtual ICollection<Room> Rooms { get; set; } = new List<Room>();

    public virtual ICollection<Staff> Staff { get; set; } = new List<Staff>();
}
