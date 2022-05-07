using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mvcproject.Models;
namespace mvcproject.Controllers
{
    public class CategoryController : Controller
    {
        private readonly NorthwindContext db;

        public CategoryController(NorthwindContext Context)
        {
            db = Context;
        }
        [HttpGet]
      

        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]

        public IActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                db.Categories.Add(category);
                db.SaveChanges();
            }
            return View();

            

        }

        public IActionResult ShowCategory()
        {
            var res = db.Categories.ToList();
            return View(res);
        }

       
    }
}
