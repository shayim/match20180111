using System;

namespace Match.Mia.Webapi.ViewModels.SalesPerson
{
    public class SalesPersonListItemVm
    {
        public SalesPersonListItemVm(Guid id, string name, string otherName, string mobile, string email, string tel)
        {
            Id = id;
            Name = name;
            OtherName = otherName;
            Mobile = mobile;
            Email = email;
            Tel = tel;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string OtherName { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
    }
}