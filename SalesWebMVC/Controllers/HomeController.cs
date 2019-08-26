using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Models;
using SalesWebMVC.Models.ViewModels;

namespace SalesWebMVC.Controllers
{
    public class HomeController : Controller //todo controlador herda de Controler. O nome Home no inicil da classe determina a pasta da View correspondente
    {
        public IActionResult Index() // IActionResult tipo generico de um resultado 
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Aplicitavo de vendas do curso de C#";
            ViewData["email"] = "higorpereirabarbosa@gmail.com";
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";
            ViewData["email"] = "higorpereirabarbosa@gmail.com";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
