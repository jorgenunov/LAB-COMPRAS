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
            List<Despesa> despesas = Repository.Despesa;
            return View(despesas);
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
                Repository.novaDespesa(d);
                return View("DespesaConfirmada", d);
            }
            else
                return View();

        }
        public IActionResult DespesaConfirmada()
        {
            return View();
        }
        
        public IActionResult LimparDespesas()
        {
            Repository.ClearDespesa();
            return View("Index", Repository.Despesa);
            
        }

    }
}