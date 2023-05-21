using System;
using System.Collections.Generic;

namespace BSBookingQuery.DAL.Entities;

public partial class RoomType
{
    public int RoomTypeId { get; set; }

    public string? RoomDetail { get; set; }

    public string? Description { get; set; }

    public int? NumberOfRooms { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<Room> Rooms { get; set; } = new List<Room>();
}
