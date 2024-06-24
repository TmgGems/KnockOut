namespace ProductCrudKnockOut.Models.ViewModels
{
    public class GetComapniesVM
    {
        public int CompanyId {  get; set; }

        public string CompanyName { get; set;}

        public List<GetProductsVM> Products { get; set; }
    }
}
