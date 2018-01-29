using System;

namespace Match.Mia.Webapi.ViewModels.Client
{
    public class ClientListItemVm
    {
        public ClientListItemVm(Guid id, string name, int typeId, string otherName = null)
        {
            Id = id;
            Name = name;
            OtherName = otherName;
            TypeId = typeId;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string OtherName { get; set; }
        public int TypeId { get; set; }
    }
}