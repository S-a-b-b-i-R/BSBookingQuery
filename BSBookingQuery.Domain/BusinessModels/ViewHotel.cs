using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BSBookingQuery.Domain.BusinessModels
{
    public class ViewHotel
    {
        public int HotelId { get; set; }

        public string? HotelCode { get; set; }

        public string? Name { get; set; }

        public string? Address { get; set; }

        public int? City { get; set; }

        public string? Phone { get; set; }

        public string? Website { get; set; }

        public string? ImagePath { get; set; }

        
    }
}
