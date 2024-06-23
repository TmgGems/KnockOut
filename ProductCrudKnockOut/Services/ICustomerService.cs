using ProductCrudKnockOut.Models;
using ProductCrudKnockOut.Models.ViewModels;

namespace ProductCrudKnockOut.Services
{
    public interface ICustomerService
    {
        List<CustomerModel> GetAllCustomers();

        CustomerModel GetCustomerById(int id);

        bool Add (CustomerModel customer);

        void Update(CustomerModel customer);

        int Delete (int id);

        List<GetProductsVM> GetProductsName();

        List<GetComapniesVM> GetComapniesName();
    }
}
