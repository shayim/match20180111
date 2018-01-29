using System.ComponentModel.DataAnnotations;

namespace Match.Domain.Common.Geolocations
{
    public class Continent
    {
        public int Id { get; set; }

        [Required, StringLength(20)]
        public string Name { get; set; }
    }
}