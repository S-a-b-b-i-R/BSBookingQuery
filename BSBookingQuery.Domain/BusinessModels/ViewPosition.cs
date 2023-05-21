using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSBookingQuery.Domain.BusinessModels
{
    public class ViewPosition
    {
        public int PositionId { get; set; }

        public string? Name { get; set; }

        public bool? IsActive { get; set; }

        public bool? IsAdmin { get; set; }

        //public virtual ICollection<Staff> Staff { get; set; } = new List<Staff>();
    }
}
