using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Primeira.Models;


namespace Primeira.Controllers
{

    [Route("api/[controller]")]
    public class ApiDespesasController : Controller
    {
        // GET: api/ApiServer
        [HttpGet]
        public List<Despesa> Get()
        {
            return Repository.Despesa;
        }

        // GET: api/ApiServer/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Despesa d = Repository.GetDespesas(id);
            if (d != null)
                return Ok(d); //return new ObjectResult(d);
            else
                return NotFound();
        }

        // POST: api/ApiServer
        [HttpPost]
        public void Post([FromBody]Despesa despesas)
        {
            Repository.novaDespesa(despesas);
        }
    }
}