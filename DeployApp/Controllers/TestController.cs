using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeployApp.Controllers
{
    [Route("Shuttle")]
    [ApiController]
    public class TestController : Controller
    {
        // GET: /Shuttle
        [HttpGet]
        public string HelloWorld()
        {
            return "Hello World!";
        }
    }
}
