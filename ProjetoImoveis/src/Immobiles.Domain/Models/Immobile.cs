using System;
using System.Collections.Generic;
using System.Text;

namespace Immobiles.Domain.Models
{
    public class Immobile
    {
        public Guid ImmobileId { get; set; }
        public EType EType { get; set; }
        public Guid AddressId { get; set; }
        public Address Address { get; set; }

        public Immobile()
        {

        }

        public Immobile(Guid immobileId, EType eType, Address address)
        {
            ImmobileId = immobileId;
            EType = eType;
            Address = address;
        }
    }
}
