using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Primeira.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Primeira.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Conceito()
        {
            return View();
        }

       [HttpGet]
        public async Task<IActionResult> Tempo()
        {
            //criar e configurar o cliente HTTP 
            HttpClient client = MyHTTPClient.Client;
            
            string path = "v1/current.json?key=45e3ca0ce8b54abcb9b85027180705&q=Paris";


            //fazer o pedido HTTP, receber a resposta, guardar JSON
            HttpResponseMessage response = client.GetAsync(path).Result;
            string json = await response.Content.ReadAsStringAsync();

            //converter JSON para um objeto do tipo WeatherApiResponse 
            WeatherApiResponse wc = JsonConvert.DeserializeObject<WeatherApiResponse>(json); 


            return View(wc);
        }

        [HttpPost]
        public async Task<IActionResult> Tempo(string cidade)
        {
            //criar e configurar o cliente HTTP 
            HttpClient client = MyHTTPClient.Client;
            string path = "v1/current.json?key=45e3ca0ce8b54abcb9b85027180705&q=" + cidade;


            //fazer o pedido HTTP, receber a resposta, guardar JSON
            HttpResponseMessage response = client.GetAsync(path).Result;
            string json = await response.Content.ReadAsStringAsync();

            //converter JSON para um objeto do tipo WeatherApiResponse 
            WeatherApiResponse wc = JsonConvert.DeserializeObject<WeatherApiResponse>(json);


            return View(wc);

        }


    }
}
