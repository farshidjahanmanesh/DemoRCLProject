using DemoRCL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoRCL.Controllers
{
    public class SampleController : Controller
    {
        private readonly IOptionsSnapshot<UserDataOptions> options;

        public SampleController(IOptionsSnapshot<UserDataOptions> options)
        {
            this.options = options;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult GetName(string name)
        {
            return View(model:name);
        }
    }
}
