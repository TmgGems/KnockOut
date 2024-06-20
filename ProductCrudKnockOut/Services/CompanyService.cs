using Microsoft.AspNetCore.Http.HttpResults;
using ProductCrudKnockOut.Data;
using ProductCrudKnockOut.Models;

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
            _context.Companies.Add(data);
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

        public void Updates(CompanyModel model)
        {
            _context.Companies.Update(model);
            _context.SaveChanges();
        }
    }
}
