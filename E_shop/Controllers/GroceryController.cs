using Microsoft.AspNetCore.Mvc;

namespace E_shop.Controllers
{
    public class GroceryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
