using System;
using System.Collections.Generic;
using System.Text;

namespace Immobiles.Domain.Models
{
    public class Address : Entity
    {
        public string Cep { get; set; }
        public string Neighborhood { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        

        public Address()
        {

        }

        public Address(string cep, string neighborhood, string streetAddress, string city, string state)
        {            
            Cep = cep;
            Neighborhood = neighborhood;
            StreetAddress = streetAddress;
            City = city;
            State = state;
        }
    }
}
