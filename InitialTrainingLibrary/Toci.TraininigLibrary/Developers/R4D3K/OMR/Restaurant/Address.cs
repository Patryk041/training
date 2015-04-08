using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.TraininigLibrary.Developers.R4D3K.OMR.Restaurant
{
    public class Address
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string StreetName { get; set; }
        public int SteetNumber { get; set; }

        public Address(string country, string city, string streetname, int number)
        {
            this.Country = country;
            this.City = city;
            this.StreetName = streetname;
            this.SteetNumber = number;
        }
    }
}
