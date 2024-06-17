using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductCrudKnockOut.Models;
using ProductCrudKnockOut.Services;

namespace ProductCrudKnockOut.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductApiController : ControllerBase
    {
        public IProductService _productservice;

        public ProductApiController(IProductService productService)
        {
            _productservice = productService;
        }

        [HttpGet]

        public IActionResult GetStudents()
        {
            List<ProductModel> students = _productservice.GetAll();
            if (students == null)
            {
                return NotFound();
            }
            return Ok(students);
        }

        [HttpGet("{id}")]
        public ProductModel GetById(int id)
        {
            var student = _productservice.GetById(id);
            return student;
        }

        [HttpPost("Add")]

        public bool Add(ProductModel obj)
        {
            return (_productservice.Add(obj));
        }

        [HttpPut("{id}")]

        public void Updates(ProductModel obj)
        {

            _productservice.Updates(obj);
        }

        [HttpDelete]

        public int Delete(int id)
        {
            _productservice.Delete(id);
            return id;
        }

    }
}
