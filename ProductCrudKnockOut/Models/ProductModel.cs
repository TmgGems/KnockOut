using System.ComponentModel.DataAnnotations;

namespace ProductCrudKnockOut.Models
{
    public class ProductModel
    {
        [Key]
        public int Id {  get; set; }

        [Display(Name ="Product Name")]
        public string Name { get; set; }

        [Display(Name = "Product Quantity")]
        public int Quantity {  get; set; }

        [Display(Name="Company Name")]
        public string Company { get; set; }
     
        [Display(Name="Manufactured Date")]
        public DateTime ManufacturedDate { get; set; }

        [Display(Name = "Expiry Date")]
        public DateTime ExpiryDate { get; set; }

        [Display(Name="Place Order")]
        public string Order { get; set; }


    }
}
