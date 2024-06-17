using Microsoft.AspNetCore.Mvc;

namespace ProductCrudKnockOut.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
