using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace kjanshair.Controllers
{
    public class BlogController : Controller
    {
        [HttpGet]
        public IActionResult AspNetCoreSystem() => View();

        [HttpGet]
        public IActionResult WebPackHMRTs() => View();
    }
}
