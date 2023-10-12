using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_shop.Controllers
{
    public class FashionController : Controller
    {
        // GET: FashionController1
        public ActionResult Index()
        {
            return View();
        }
    }
}
