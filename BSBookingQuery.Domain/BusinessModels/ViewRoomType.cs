using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSBookingQuery.Domain.BusinessModels
{
    public class ViewRoomType
    {
        public int RoomTypeId { get; set; }

        public string? RoomDetail { get; set; }

        public string? Description { get; set; }

        public int? NumberOfRooms { get; set; }

        public bool? IsActive { get; set; }

        //public virtual ICollection<Room> Rooms { get; set; } = new List<Room>();
    }
}
