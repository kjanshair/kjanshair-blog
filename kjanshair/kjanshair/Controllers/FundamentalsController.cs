using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace kjanshair.Controllers
{
    public class FundamentalsController : Controller
    {
        [HttpGet]
        public IActionResult DotNetCore() => View();

        [HttpGet]
        public IActionResult SmallAspNetCoreApp() => View();
    }
}
