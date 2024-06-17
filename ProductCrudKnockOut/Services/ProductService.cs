using Microsoft.AspNetCore.Http.HttpResults;
using ProductCrudKnockOut.Data;
using ProductCrudKnockOut.Models;

namespace ProductCrudKnockOut.Services
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _context;

        public ProductService(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Add(ProductModel model)
        {
            _context.Products.Add(model);
            _context.SaveChanges();
            return true;
        }

        public int Delete(int id)
        {
            var data = _context.Products.Find(id);           
            _context.Products.Remove(data);
            _context.SaveChanges();

            return id;
        }

        public List<ProductModel> GetAll()
        {
            var products = _context.Products.ToList();
            return products;
        }

        public ProductModel GetById(int id)
        {
            var product = _context.Products.Find(id);
            return product;
        }

        public void Updates(ProductModel model)
        {
            _context.Products.Update(model);
            _context.SaveChanges();
        }
    }
}
