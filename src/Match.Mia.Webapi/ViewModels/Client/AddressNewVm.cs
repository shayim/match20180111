using System.ComponentModel.DataAnnotations;

namespace Match.Mia.Webapi.ViewModels.Client
{
    public class AddressNewVm
    {
        [Required]
        public string Street { get; set; }

        public int TypeId { get; set; }

        public int? DistrictId { get; set; }

        public int? CityId { get; set; }
    }
}