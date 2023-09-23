using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_shop.Controllers
{
    public class ElectronicsController : Controller
    {
        // GET: ElectronicsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ElectronicsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ElectronicsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ElectronicsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ElectronicsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ElectronicsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ElectronicsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ElectronicsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
