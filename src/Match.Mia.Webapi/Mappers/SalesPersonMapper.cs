using System.Collections.Generic;
using System.Data;
using Match.Domain.BusinessParties;
using Match.Mia.Webapi.ViewModels.SalesPerson;

namespace Match.Mia.Webapi.Mappers
{
    public static class SalesPersonMapper
    {
        public static SalesPersonListItemVm ToSalesPersonListItemVm(this ClientSalesPerson clientSalesPerson)
        {
            var salesPerson = clientSalesPerson.SalesPerson.Employee.Person;
            if (salesPerson == null) throw new DataException("ClientSalesPerson sales cannot be null");

            return new SalesPersonListItemVm(salesPerson.Id, salesPerson.Name, salesPerson.OtherName, salesPerson.Mobile,
                salesPerson.Email, salesPerson.Tel);
        }

        public static IEnumerable<SalesPersonListItemVm> ToSalesPersonList(
            this IEnumerable<ClientSalesPerson> clientSalesPersonList)
        {
            var salesList = new HashSet<SalesPersonListItemVm>();
            foreach (var salesPerson in clientSalesPersonList)
            {
                if (salesPerson.IsActive)
                {
                    salesList.Add(salesPerson.ToSalesPersonListItemVm());
                }
            }
            return salesList; ;
        }
    }
}