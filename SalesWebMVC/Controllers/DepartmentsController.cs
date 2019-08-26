using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Models;

namespace SalesWebMVC.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List < Departments > list = new List<Departments>();
            list.Add(new Departments { Name = "Eletronicos", Id = 1 });
            list.Add(new Departments { Name = "Fashion", Id = 2 });

            return View(list); // enviando lista como argumento
        }
    }
}