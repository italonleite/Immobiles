using System;
using System.Collections.Generic;
using System.Text;

namespace Immobiles.Domain.Models
{
    public class Immobile : Entity
    {
        public EType EType { get; set; }
        public Guid AddressId { get; set; }
        public Address Address { get; set; }

        public Immobile()
        {

        }
        public Immobile(EType eType, Address address)
        {
            
            EType = eType;
            Address = address;
            AddressId = address.Id;
        }
    }
}
