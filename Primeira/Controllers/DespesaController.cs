using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Primeira.Models;

namespace Primeira.Controllers
{
    public class DespesaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult NovaDespesa()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NovaDespesa(Despesa d)
        {
            if (ModelState.IsValid)
            {
                return View("DespesaConfirmada", d);
            }
            else
                return View();

        }
    }
}