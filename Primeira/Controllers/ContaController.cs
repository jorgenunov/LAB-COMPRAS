using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Primeira.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Primeira.Controllers
{
    public class ContaController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            List<Conta> contas = Repository.Contas;
            return View(contas);
        }
        [HttpGet]
        public IActionResult NovaConta()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NovaConta(Conta c)
        {
            if (ModelState.IsValid)
            {
                Repository.AddConta(c);
                return View("ContaConfirmada", c);
            }
            else
                return View();
        }

        public IActionResult ContaConfirmada()
        {
            return View();

        }

        public IActionResult LimparContas()
        {
            Repository.ClearContas();
            return View("Index", Repository.Contas);
        }
        

    }

}
