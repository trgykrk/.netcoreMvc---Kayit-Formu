using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMvcTask.Controllers
{
    public class HizmetlerimizController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
