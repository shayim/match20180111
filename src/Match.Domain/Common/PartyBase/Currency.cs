using System.ComponentModel.DataAnnotations;

namespace Match.Domain.Common.PartyBase
{
    public class Currency
    {
        //key
        public string Code { get; set; }

        [StringLength(20)]
        public string Name { get; set; }
    }
}