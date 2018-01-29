using System;

namespace Match.Mia.Webapi.ViewModels.SalesPerson
{
    public class SalesPersonSelectItemVm
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public SalesPersonSelectItemVm(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}