using System;
using System.Data;
using Match.Domain.BusinessParties;
using Match.Domain.Common.PartyBase;
using Match.Mia.Webapi.ViewModels.Client;

namespace Match.Mia.Webapi.Mappers
{
    public static class ClientMapper
    {
        public static ClientListItemVm ToClientListItemVm(this Client client)
        {
            if (client.Party == null) throw new DataException("client party cannot be null");

            return new ClientListItemVm
            (
                client.Id,
                client.Party.Name,
                client.Party.PartyType,
                client.Party.OtherName
            );
        }

        public static ClientDetailsVm ToClientDetailsVm(this Client client)
        {
            var clientDetails = new ClientDetailsVm(client.Id, client.Party.Name, client.Party.OtherName)
            {
                Contacts = client.Party.Contacts.ToContactList(),
                Sales = client.CurrentSalesPersons.ToSalesPersonList(),
                Addresses = client.Party.Addresses.ToAddressListSingleLineVm()
            };

            return clientDetails;
        }
    }
}