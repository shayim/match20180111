using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Match.Domain.Common.Geolocations
{
    public class City
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }

        public int? StateProvinceId { get; set; }

        public int CountryId { get; set; }

        public ICollection<District> Districts { get; set; } = new List<District>();

        public ICollection<ZipCode> ZipCodes { get; set; } = new List<ZipCode>();
    }
}