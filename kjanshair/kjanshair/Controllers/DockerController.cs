using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace kjanshair.Controllers
{
    public class DockerController : Controller
    {
        [HttpGet]
        public IActionResult Microservices() => View();

        [Route("blog/IntroToDocker")]
        [Route("docker/IntroToDocker")]
        [HttpGet]
        public IActionResult IntroToDocker() => View();

        [Route("blog/DockerizeAspNetCore")]
        [Route("docker/DockerizeAspNetCore")]
        [HttpGet]
        public IActionResult DockerizeAspNetCore() => View();

        [Route("blog/DockerOnAzure")]
        [Route("docker/DockerOnAzure")]
        [HttpGet]
        public IActionResult DockerOnAzure() => View();

        [HttpGet]
        public IActionResult DockerCompose() => View();

        [HttpGet]
        public IActionResult AspNetCoreSqlServer() => View();

        [HttpGet]
        public IActionResult DockerVolumes() => View();
    }
}
