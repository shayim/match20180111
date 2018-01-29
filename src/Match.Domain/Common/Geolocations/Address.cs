using System.ComponentModel.DataAnnotations;

namespace Match.Domain.Common.Geolocations
{
    public class Address
    {
        protected Address()
        {
        }

        public Address(string street, District district = null, City city = null)
        {
            Street = street;
            District = district;
            City = city;
        }

        public int Id { get; set; }

        [Required]
        public string Street { get; set; }

        public int? DistrictId { get; set; }

        public int? CityId { get; set; }

        public int? StateProvinceId { get; set; }

        public int? CountryId { get; set; }

        public string ZipCode { get; set; }

        public District District { get; set; }

        public City City { get; set; }

        public StateProvince StateProvince { get; set; }

        public Country Country { get; set; }
    }
}