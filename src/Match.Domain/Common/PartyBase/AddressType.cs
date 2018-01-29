using System.ComponentModel.DataAnnotations;

namespace Match.Domain.Common.PartyBase
{
    public class AddressType
    {
        public int Id { get; set; }

        [Required, StringLength(20)]
        public string Name { get; set; }
    }
}