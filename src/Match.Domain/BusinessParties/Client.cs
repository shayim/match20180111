using System;
using System.Collections.Generic;
using Match.Domain.Common.PartyBase;

namespace Match.Domain.BusinessParties
{
    public class Client : Entity<Guid>
    {
        public Client() : base(default(Guid))
        { }

        public Client(Party party) : base(party.Id)
        {
            Party = party;
        }

        public Party Party { get; private set; }
        public ICollection<ClientSalesPerson> CurrentSalesPersons { get; set; } = new List<ClientSalesPerson>();

        public void AddSalesPerson(SalesPerson sales)
        {
            CurrentSalesPersons.Add(new ClientSalesPerson(this, sales));
        }
    }
}