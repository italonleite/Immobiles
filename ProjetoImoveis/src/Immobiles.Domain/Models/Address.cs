using System;
using System.Collections.Generic;
using System.Text;

namespace Immobiles.Domain.Models
{
    public class Address
    {
        public Guid AddressId { get; set; }
        public string Cep { get; set; }
        public string Neighborhood { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public Immobile Immobiles { get; set; }



        public Address()
        {

        }

        public Address(Guid addressId, string cep, string neighborhood, string streetAddress, string city, string state)
        {
            AddressId = addressId;
            Cep = cep;
            Neighborhood = neighborhood;
            StreetAddress = streetAddress;
            City = city;
            State = state;
        }
    }
}
