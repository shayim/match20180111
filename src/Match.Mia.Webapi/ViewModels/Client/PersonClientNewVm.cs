using System;
using System.ComponentModel.DataAnnotations;
using Match.Domain.Common.PartyBase;

namespace Match.Mia.Webapi.ViewModels.Client
{
    public class PersonClientNewVm : ClientNewVm
    {
        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(20)]
        public string Mobile { get; set; }

        public Gender Gender { get; set; }
        public DateTime? BirthDate { get; set; }
        public int? NationalityId { get; set; }
    }
}