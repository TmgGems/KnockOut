using Microsoft.AspNetCore.Mvc;

namespace ProductCrudKnockOut.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
