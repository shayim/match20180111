using System.Collections.Generic;
using Match.Domain.Common.Geolocations;
using Match.Domain.Common.PartyBase;
using Match.Mia.Webapi.ViewModels.Client;
using Match.Mia.Webapi.ViewModels.Common;
using Match.Repository;

namespace Match.Mia.Webapi.Mappers
{
    public static class AddressMapper
    {
        public static Address ToAddress(this AddressNewVm addressVm, BusinessPartyDbContext context)
        {
            City city = null;
            District district = null;

            if (addressVm.CityId.HasValue)
            {
                city = context.City.Find(addressVm.CityId);
            }

            if (addressVm.DistrictId.HasValue)
            {
                district = context.District.Find(addressVm.DistrictId);
            }

            return new Address(addressVm.Street, district, city);
        }

        public static IEnumerable<Address> ToAddressList(this IEnumerable<AddressNewVm> addressVms,
            BusinessPartyDbContext context)
        {
            var addressList = new HashSet<Address>();
            foreach (var address in addressVms)
            {
                addressList.Add(address.ToAddress(context));
            }
            return addressList;
        }

        public static AddressSingleLineVm ToAddressSingleLineVm(this PartyAddress partyAddress)
        {
            var address = partyAddress.Address;
            return new AddressSingleLineVm { Address = address.Street, Id = address.Id, TypeId = 1 };
        }

        public static IEnumerable<AddressSingleLineVm> ToAddressListSingleLineVm(this IEnumerable<PartyAddress> addresses)
        {
            var addressList = new HashSet<AddressSingleLineVm>();
            foreach (var address in addresses)
            {
                addressList.Add(address.ToAddressSingleLineVm());
            }
            return addressList;
        }
    }
}