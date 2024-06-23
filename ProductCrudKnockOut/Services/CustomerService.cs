using ProductCrudKnockOut.Data;
using ProductCrudKnockOut.Models;
using ProductCrudKnockOut.Models.ViewModels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProductCrudKnockOut.Services
{
    public class CustomerService : ICustomerService
    {

        public ApplicationDbContext _context;

        public CustomerService(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Add(CustomerModel customer)
        {
            var companyExists = _context.Companies.Any(c => c.Id == customer.CompanyId );
            if(!companyExists)
            {
                return false;
            }
            else
            {
                try
                {

                    _context.Customers.Add(customer);
                    _context.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }          
        }

        public int Delete(int id)
        {
            var  modeldata = _context.Customers.Find(id);
            if (modeldata != null)
            {
                _context.Customers.Remove(modeldata);
                return modeldata.Id;
            }
            else
                return 0;
        }

        public List<CustomerModel> GetAllCustomers()
        {
            var dataList = _context.Customers.ToList();
            return dataList;
        }


        public CustomerModel GetCustomerById(int id)
        {
            var data = _context.Customers.Find(id);
            return data;
        }


        public void Update(CustomerModel customer)
        {
            _context.Customers.Update(customer);
            _context.SaveChanges();
        }
        public List<GetComapniesVM> GetComapniesName()
        {
            var datas = _context.Companies.Select(company => new GetComapniesVM
            {
                CompanyId = company.Id,
                CompanyName = company.CompanyName
            }).ToList();
            return datas;
        }
        public List<GetProductsVM> GetProductsName()
        {
            var datas = _context.Products.Select(product => new GetProductsVM
            {
                ProductId = product.Id,
                ProductName = product.Name
            }).ToList();
            return datas;
        }
    }
}
