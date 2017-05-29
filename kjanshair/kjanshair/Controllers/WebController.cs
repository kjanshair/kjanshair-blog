using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace kjanshair.Controllers
{
    public class WebController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        #region Client

        [HttpGet]
        public IActionResult Grunt() => View("~/Views/Web/Front/Grunt.cshtml");

        [HttpGet]
        public IActionResult Yeoman() => View("~/Views/Web/Front/Yeoman.cshtml");

        [HttpGet]
        public IActionResult Angular() => View("~/Views/Web/Front/Angular.cshtml");

        [HttpGet]
        public IActionResult LESS_SASS() => View("~/Views/Web/Front/LESS_SASS.cshtml");
        #endregion

        #region Server
        [HttpGet]
        public IActionResult ProjectStructure() => View("~/Views/Web/Back/ProjectStructure.cshtml");

        [HttpGet]
        public IActionResult DI() => View("~/Views/Web/Back/DI.cshtml");

        [HttpGet]
        public IActionResult Identity() => View("~/Views/Web/Back/Identity.cshtml");

        [HttpGet]
        public IActionResult Logging() => View("~/Views/Web/Back/Logging.cshtml");

        [HttpGet]
        public IActionResult EFCore() => View("~/Views/Web/Back/EFCore.cshtml");

        [HttpGet]
        public IActionResult ViewComponents() => View("~/Views/Web/Back/ViewComponents.cshtml");
        #endregion
    }
}
