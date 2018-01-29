using System;

namespace Match.Domain.BusinessParties
{
    public class ClientSalesPerson
    {
        protected ClientSalesPerson()
        {
        }

        public ClientSalesPerson(Client client, SalesPerson sales)
        {
            Client = client;
            SalesPerson = sales;
        }

        public Guid ClientId { get; set; }
        public Guid SalesPersonId { get; set; }
        public bool IsActive { get; set; } = true;
        public Client Client { get; set; }
        public SalesPerson SalesPerson { get; set; }
    }
}