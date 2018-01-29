using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Match.Domain.Common.Geolocations
{
    public class District
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }

        public int CityId { get; set; }

        public ICollection<ZipCode> ZipCodes { get; set; } = new List<ZipCode>();
    }
}