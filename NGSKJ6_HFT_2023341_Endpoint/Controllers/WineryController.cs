using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NGSKJ6_HFT_2023241_Logic;
using NGSKJ6_HFT_2023241_Logic.Interfaces;
using NGSKJ6_HFT_2023241_Models;
using System.Collections.Generic;

namespace NGSKJ6_HFT_2023341_Endpoint.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class WineryController : Controller
    {
        IWineryLogic logic;
        public WineryController(IWineryLogic logic)
        {
            this.logic = logic;
        }
        // GET: Winery

        public ActionResult Index()
        {
            return View();
        }

        // GET: Winery/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Winery/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Winery/Create
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

        // GET: Winery/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Winery/Edit/5
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

        // GET: Winery/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Winery/Delete/5
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
