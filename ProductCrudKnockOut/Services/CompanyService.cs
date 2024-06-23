using Microsoft.AspNetCore.Http.HttpResults;
using ProductCrudKnockOut.Data;
using ProductCrudKnockOut.Models;
using ProductCrudKnockOut.Models.ViewModels;

namespace ProductCrudKnockOut.Services
{
    public class CompanyService :ICompanyService
    {
        public ApplicationDbContext _context;
        public CompanyService(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool Add(CompanyModel model)
        {
           var data = _context.Products.Find(model.ProductId);
            if(data != null) 
            {
                _context.Companies.Add(model);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public int Delete(int id)
        {
            var data = _context.Companies.Find(id);
            _context.Companies.Remove(data);
            _context.SaveChanges();
            return id;
        }

        public List<CompanyModel> GetAll()
        {
            var datasfromDb = _context.Companies.ToList();

            return datasfromDb;
        }

        public CompanyModel GetById(int id)
        {
            var datafromDb = _context.Companies.Find(id);
            return datafromDb;
        }

        public List<CompanyProductViewModel> GetCompanieesWithProducts()
        {
            var companyProducts = from company in _context.Companies
                                  join product in _context.Products on company.ProductId equals product.Id

                                  select new CompanyProductViewModel
                                  {
                                      Id = company.Id,
                                      CompanyName = company.CompanyName,
                                      ProductManufactured = product.Name,
                                      ProductId = product.Id,
                                      CompanyEstd = company.CompanyEstd,
                                      CompanyPhNo = company.CompanyPhNo

                                  };
            return companyProducts.ToList();

        }

        public List<string> GetProductNames()
        {
            List<string> productNames = _context.Products.Select(p => p.Name).ToList();

            return productNames;
        }

        public IEnumerable<GetProductsVM> GetProducts()
        {
            var products = _context.Products.Select( product => new GetProductsVM
            {
                ProductId = product.Id,
                ProductName = product.Name
            }).ToList();
            return products;
        }

        public void Updates(CompanyModel model)
        {
            _context.Companies.Update(model);
            _context.SaveChanges();
        }

       
    }
}
