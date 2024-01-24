using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1_menu_dziedziczenie.classes
{
    internal class Adress
    {
        public string City { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string PostalCode { get; set; }

        public Adress(string city, string street, string housenumber, string postalcode)
        {
            City = city;
            Street = street;
            HouseNumber = housenumber;
            PostalCode = postalcode;
        }
        public Adress() { }
    }
}
