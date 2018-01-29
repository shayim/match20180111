using System;
using Match.Domain.Common.Geolocations;

namespace Match.Domain.Common.PartyBase
{
    public class PartyAddress
    {
        public PartyAddress() { }
        public PartyAddress(Party party, Address address, AddressType addressType)
        {
            PartyId = party.Id;
            Address = address;
            Type = addressType;
        }

        //key
        public Guid PartyId { get; set; }

        //key
        public int AddressId { get; set; }

        public bool IsActive { get; set; }

        public int AddressTypeId { get; set; }

        public Address Address { get; set; }
        public AddressType Type { get; set; }
    }
}