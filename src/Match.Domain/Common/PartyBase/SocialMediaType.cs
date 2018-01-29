using System.ComponentModel.DataAnnotations;

namespace Match.Domain.Common.PartyBase
{
    public class SocialMediaType
    {
        public int Id { get; set; }

        [Required, StringLength(20)]
        public string Name { get; set; }
    }
}