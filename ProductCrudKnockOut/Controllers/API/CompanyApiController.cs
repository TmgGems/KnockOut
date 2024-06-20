using Microsoft.AspNetCore.Mvc;
using ProductCrudKnockOut.Models;
using ProductCrudKnockOut.Services;

namespace ProductCrudKnockOut.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyApiController
    {
        public ICompanyService _companyService;
        public CompanyApiController(ICompanyService companyService)
        {
            _companyService = companyService;
        }
        [HttpGet]
        public List<CompanyModel> GetCompanies()
        {
            var datas = _companyService.GetAll();
            return datas;
        }

        [HttpPost]
        public bool Add(CompanyModel model)
        {
           
            bool data = _companyService.Add(model);
            if(data)
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
    }
}
