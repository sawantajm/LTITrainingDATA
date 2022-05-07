using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvcproject.Controllers
{
    public class regController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
