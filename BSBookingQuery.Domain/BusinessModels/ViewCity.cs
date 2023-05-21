using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSBookingQuery.Domain.BusinessModels
{
    public class ViewCity
    {
        public int CityId { get; set; }

        public int? CountryId { get; set; }

        public string? Name { get; set; }

        public bool? IsActive { get; set; }
        //public virtual Country? Country { get; set; }

        //public virtual ICollection<Staff> Staff { get; set; } = new List<Staff>();
    }
}
