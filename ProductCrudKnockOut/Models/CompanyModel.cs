using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Text.Json.Serialization;

namespace ProductCrudKnockOut.Models
{
    public class CompanyModel
    {
        public int Id { get; set; }

        public string CompanyName {  get; set; }

        public string ProductManufactured {  get; set; }

        public DateTime CompanyEstd { get; set; }

        public string CompanyPhNo { get; set;}

        public int ProductId {  get; set; }
       
        [ValidateNever]
        [JsonIgnore]
        public ProductModel ? Product {  get; set; }
    }
}
