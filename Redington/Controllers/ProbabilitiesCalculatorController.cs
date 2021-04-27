using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Redington.BusinessLayer.Logic.ILogic;
using Redington.Models;
using Redington.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Redington.Controllers
{
    public class ProbabilitiesCalculatorController : Controller
    {
        private readonly IProbabilityCalculation _probabilityCalculation;
        public ProbabilitiesCalculatorController(IProbabilityCalculation _probabilityCalculation)
        {
            this._probabilityCalculation = _probabilityCalculation;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(ProbabilityViewModel probabilityVM)
        {
            if (!ModelState.IsValid)
                return View(probabilityVM);

            var probability = new Probability();
            probability.A = probabilityVM.A;
            probability.B = probabilityVM.B;
            probability.FunctionType = probabilityVM.FunctionType;

            var result = _probabilityCalculation.Set(probability);

            return RedirectToAction("Result", new { result = result });
        }

        public IActionResult Result(float result)
        {
            ViewBag.Result = result;

            return View();
        }
    }
}
