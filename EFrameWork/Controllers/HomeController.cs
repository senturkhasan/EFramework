using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EFrameWork.Models;
using System.Runtime.InteropServices.WindowsRuntime;

namespace EFrameWork.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private IProductRepository repository;
        public HomeController(IProductRepository repo)
        {
            repository = repo;
        }
        /* public HomeController(ILogger<HomeController> logger)
         {
             _logger = logger;
         }*/

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


        public IActionResult List() => View(repository.Products);//Where(i => i.Price > 100).FirsOrDefault();//ilk değer gelir

        [HttpGet]
        public IActionResult Create()=> View();
        [HttpPost]
        public IActionResult Create(Product product) {

            repository.CreateProduct(product);
            return RedirectToAction("List");
        }

       [HttpGet]
        public IActionResult Details(int id)=> View(repository.GetById(id));

        [HttpPost]
        public IActionResult Details(Product product)
        {
            repository.UpdateProduct(product);
            return RedirectToAction("List");

        }
        public IActionResult Delete(int id)
        {
            repository.DeleteProduct(id);
            return RedirectToAction("List");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
