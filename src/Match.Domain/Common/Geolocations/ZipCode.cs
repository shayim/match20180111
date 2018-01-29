namespace Match.Domain.Common.Geolocations
{
    public class ZipCode
    {
        // KEY
        public string Code { get; set; }

        // KEY
        public int CityId { get; set; }

        public int? CountryId { get; set; }
        public int? ProvinceId { get; set; }
        public int? DistrictId { get; set; }
    }
}