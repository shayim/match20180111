using System;
using System.ComponentModel.DataAnnotations;
using Match.Mia.Webapi.ViewModels.Common;

namespace Match.Mia.Webapi.ViewModels.Client
{
    public class ClientNewVm : PartyNewVm
    {
        [Required]
        public Guid SalesPersonId { get; set; }
    }
}