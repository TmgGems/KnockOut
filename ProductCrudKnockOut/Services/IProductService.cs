using ProductCrudKnockOut.Models;

namespace ProductCrudKnockOut.Services
{
    public interface IProductService
    {
        List<ProductModel> GetAll();

        ProductModel GetById(int id);

        bool Add(ProductModel model);

        void Updates(ProductModel model);

        int Delete(int  id);
    }
}
