using System;
using System.Collections.Generic;
using System.Text;

namespace Immobiles.Domain.Models
{
    public class Address
    {
        public Guid EnderecoId { get; set; }
        public string Cep { get; set; }
        public string Neighborhood { get; set; }
        public string StreetAddres { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public Address()
        {

        }

        public Address(Guid enderecoId, string cep, string neighborhood, string streetAddres, string city, string state)
        {
            EnderecoId = enderecoId;
            Cep = cep;
            Neighborhood = neighborhood;
            StreetAddres = streetAddres;
            City = city;
            State = state;
        }
    }
}
