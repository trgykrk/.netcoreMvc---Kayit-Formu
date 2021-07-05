using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMvcTask.Controllers
{
    public class KurumsalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
