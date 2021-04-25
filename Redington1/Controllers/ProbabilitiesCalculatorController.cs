using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Redington.Controllers
{
    public class ProbabilitiesCalculatorController : Controller
    {
        // GET: ProbabilitiesCalculatorController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ProbabilitiesCalculatorController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProbabilitiesCalculatorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProbabilitiesCalculatorController/Create
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

        // GET: ProbabilitiesCalculatorController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProbabilitiesCalculatorController/Edit/5
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

        // GET: ProbabilitiesCalculatorController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProbabilitiesCalculatorController/Delete/5
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
