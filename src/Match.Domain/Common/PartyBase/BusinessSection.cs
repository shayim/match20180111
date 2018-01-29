using System.ComponentModel.DataAnnotations;

namespace Match.Domain.Common.PartyBase
{
    public class BusinessSection
    {
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Name { get; set; }
    }
}