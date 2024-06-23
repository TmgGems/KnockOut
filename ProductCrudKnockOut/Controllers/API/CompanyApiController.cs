using Amazon.DynamoDBv2;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductCrudKnockOut.Data;
using ProductCrudKnockOut.Models;
using ProductCrudKnockOut.Models.ViewModels;
using ProductCrudKnockOut.Services;
using System.ComponentModel.Design;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace ProductCrudKnockOut.Controllers.API
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CompanyApiController
    {
        public ICompanyService _companyService;
        private ApplicationDbContext _db;
        public CompanyApiController(ICompanyService companyService, ApplicationDbContext db)
        {
            _companyService = companyService;
            _db = db;

        }
        [HttpGet]
        public List<CompanyModel> GetCompanies()
        {
            var datas = _companyService.GetAll();
            return datas;
        }

        [HttpGet]
        public IEnumerable<GetProductsVM> GetProductsVM()
        {
            var datas = _companyService.GetProducts();
            return datas;
        }

        [HttpPost]
        public bool Add(CompanyModel model)
        {

            bool data = _companyService.Add(model);
            if (data)
            {
                return true;
            }
            return false;
        }

        [HttpGet("{id}")]

        public CompanyModel GetById(int id)
        {
            var data = _companyService.GetById(id);
            return data;
        }

        [HttpPut]

        public void Updates(CompanyModel model)
        {
            _companyService.Updates(model);
        }

        [HttpDelete]

        public int Delete(int id)
        {
            _companyService.Delete(id);
            return id;
        }


        [HttpGet]
        public List<CompanyProductViewModel> GetCompanieesWithProducts()
        {
            var data = _companyService.GetCompanieesWithProducts();
            return data;
        }
        //[HttpGet]
        //public List<string> GetProductNames()
        //{
        //    return _companyService.GetProductNames();
        //}


        //[HttpGet("/[action]")]
        //public List<CompanyViewModel> getCompanywithProd()
        //{



        //    var cmp = _db.Companies.Select(x => new { CompanyName = x.CompanyName, ProductManufactured = x.Product.Name, CompanyEstd = x.CompanyEstd, CompanyPhNo = x.CompanyPhNo });

        //    List<CompanyViewModel> vm = new List<CompanyViewModel>();
        //    foreach (var company in cmp)
        //    {

        //        vm.Add(new CompanyViewModel { CompanyEstd = company.CompanyEstd, CompanyName = company.CompanyName, CompanyPhNo = company.CompanyPhNo, ProductManufactured = company.ProductManufactured });
        //    }
        //    return vm;
        //}

        //[HttpGet("/[action]")]

        //public ProductViewModel CompanyProduct()
        //{



        //    var product = _db.Products.ToList();
        //    var company = _db.Companies.ToList();
        //    var result = new ProductViewModel()
        //    {
        //        CompanyList = company,
        //        ProductList = product,
        //    };
        //    return result;


        //}
    }
}
