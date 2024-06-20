using Microsoft.AspNetCore.Mvc;

namespace ProductCrudKnockOut.Controllers
{
    public class CompanyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
