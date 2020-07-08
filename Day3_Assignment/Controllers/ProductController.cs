using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Day3_Assignment.Models; 

namespace Day3_Assignment.Controllers
{
    public class ProductController : Controller
    {
        public List<Product> list=new List<Product>()
        {
            new Product(){pid="1",pname="Chocolate",stock=50,price=10}
        };
        public IActionResult Index(String uid)
        {
            Product p = list.SingleOrDefault(i => i.pid == uid);
            return View(p);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product p)
        {
            if (ModelState.IsValid)
            {
                list.Add(p);
                Console.WriteLine(list);
                return RedirectToAction("GetAll");
            }
            else
            {
                return View("Create");
            }
        }
        public IActionResult GetAll()
        {
            return View(list);
        }
    }
}
