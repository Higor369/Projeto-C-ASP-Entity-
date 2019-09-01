using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Models;
using SalesWebMVC.Services;
using SalesWebMVC.Models.ViewModels;

namespace SalesWebMVC.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerService; // depencia para acessar o servico
        private readonly DepartmentService _departmentService;
        public IActionResult Index()
        {
            var list = _sellerService.FindAll();
            return View(list); //instancia a lista na view
        }

        public SellersController(SellerService sellerService, DepartmentService departmentService)
        {
            _departmentService = departmentService;
            _sellerService = sellerService; //instanciando dependencia 
        }
        public IActionResult Create()
        {
            var departments = _departmentService.FindAll();
            var viewModel = new SellerFormViewModel { Department = departments };
            return View(viewModel);
        }
        [HttpPost] //informa tipo de requisiçao
        [ValidateAntiForgeryToken]
        public IActionResult Create(Seller seller)
        {
            _sellerService.Insert(seller);
            return RedirectToAction(nameof(Index)); //faz o retorno da view para o usuário 
        }
    }
}