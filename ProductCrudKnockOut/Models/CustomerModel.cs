using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ProductCrudKnockOut.Models
{
    public class CustomerModel
    {
        [Key]
        public int Id { get; set; }

        public string CustomerName { get; set; }

        public string CustomerAddress {  get; set; }

        public int CompanyId {  get; set; }
        [ValidateNever]
        [JsonIgnore]
        public CompanyModel ? Company { get; set; }

        public string Gender {  get; set; }
    }
}
