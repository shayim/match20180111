using System;
using System.Collections.Generic;
using Match.Domain.Common.Business;

namespace Match.Domain.BusinessParties
{
    public class SalesPerson : Entity<Guid>
    {
        protected SalesPerson() : base(default(Guid))
        { }

        public SalesPerson(Employee employee) : base(employee.Id)
        {
            Employee = employee;
        }

        public Employee Employee { get; private set; }

        public SalesPersonType SalesPersonType { get; set; }

        public ICollection<ClientSalesPerson> Clients { get; set; } = new List<ClientSalesPerson>();
    }
}