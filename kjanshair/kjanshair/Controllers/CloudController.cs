using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace kjanshair.Controllers
{
    public class CloudController : Controller
    {
        public IActionResult ARM() => View();
        public IActionResult ARMVMS() => View();
        public IActionResult CoreOSDocker() => View();
    }
}
