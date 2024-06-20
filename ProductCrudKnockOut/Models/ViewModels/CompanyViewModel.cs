using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ProductCrudKnockOut.Models.ViewModels
{
    public class CompanyViewModel
    {
        [Key]
       // public int CompanyId {  get; set; }

        public string CompanyName { get; set; }

        public string ProductManufactured { get; set; }

        public DateTime CompanyEstd { get; set; }

        public string CompanyPhNo { get; set; }


    }
   
}
