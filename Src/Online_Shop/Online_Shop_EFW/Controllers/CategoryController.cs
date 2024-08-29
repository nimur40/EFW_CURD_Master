using Microsoft.AspNetCore.Mvc;

namespace Online_Shop_EFW.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
