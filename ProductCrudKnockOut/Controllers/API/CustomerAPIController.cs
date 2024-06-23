using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductCrudKnockOut.Models;
using ProductCrudKnockOut.Models.ViewModels;
using ProductCrudKnockOut.Services;

namespace ProductCrudKnockOut.Controllers.API
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class CustomerAPIController : ControllerBase
    {
        public ICustomerService _customerService { get; set; }
        public CustomerAPIController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public List<CustomerModel> GetAllCustomers()
        {
            return _customerService.GetAllCustomers();
        }

        [HttpGet]
        public CustomerModel GetCustomerById(int id)
        {
            return _customerService.GetCustomerById(id);
        }

        [HttpPost]
        public bool Add(CustomerModel customer)
        {
            return _customerService.Add(customer);
        }
        [HttpPut]
        public void Update(CustomerModel customer)
        {
            _customerService.Update (customer);
        }

        [HttpDelete]
        public int Delete(int id)
        {
            return _customerService.Delete(id);
        }

        [HttpGet]
        public List<GetProductsVM> GetProductsName()
        {
            return _customerService.GetProductsName();
        }

        [HttpGet]
        public List<GetComapniesVM> GetComapniesName()
        {
            return _customerService.GetComapniesName();
        }
    }
}
