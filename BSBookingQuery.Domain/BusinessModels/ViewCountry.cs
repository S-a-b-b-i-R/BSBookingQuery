﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSBookingQuery.Domain.BusinessModels
{
    public class ViewCountry
    {
        public int CountryId { get; set; }

        public string? Name { get; set; }

        public bool? IsActive { get; set; }

        //public virtual ICollection<City> Cities { get; set; } = new List<City>();
    }
}
