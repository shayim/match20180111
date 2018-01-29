using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Match.Domain.Common.Geolocations
{
    public class Country
    {
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Name { get; set; }

        public int ContinentId { get; set; }

        public ICollection<City> Cities { get; set; } = new List<City>();

        public ICollection<StateProvince> StateProvinces { get; set; } = new List<StateProvince>();

        public ICollection<ZipCode> ZipCodes { get; set; } = new List<ZipCode>();
    }
}