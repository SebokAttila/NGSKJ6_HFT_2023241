using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NGSKJ6_HFT_2023341_Endpoint.Controllers
{
    public class BarrellController : Controller
    {
        // GET: Barrell
        public ActionResult Index()
        {
            return View();
        }

        // GET: Barrell/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Barrell/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Barrell/Create
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

        // GET: Barrell/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Barrell/Edit/5
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

        // GET: Barrell/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Barrell/Delete/5
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
