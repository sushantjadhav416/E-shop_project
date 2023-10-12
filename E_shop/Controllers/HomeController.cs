using E_shop.Data;
using E_shop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Web;
using Microsoft.AspNetCore.Session;
using System.Security.Cryptography;
//using MySqlX.XDevAPI;
using System.Text;

namespace E_shop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}