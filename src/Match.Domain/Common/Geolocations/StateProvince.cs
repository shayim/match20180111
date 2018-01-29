using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Match.Domain.Common.Geolocations
{
    public class StateProvince
    {
        public StateProvince(string name, Country country)
        {
            Name = name;
            CountryId = country.Id;
        }

        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }

        public int CountryId { get; set; }

        public ICollection<City> Cities { get; set; } = new List<City>();

        public ICollection<ZipCode> ZipCodes { get; set; } = new List<ZipCode>();
    }
}