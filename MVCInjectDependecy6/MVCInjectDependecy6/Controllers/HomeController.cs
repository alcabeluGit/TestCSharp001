using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCInjectDependecy6.Models;

namespace MVCInjectDependecy6.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ITransient _transient;
        private readonly IScoped _scoped;
        private readonly ISinglenton _singlenton;

        public HomeController(ILogger<HomeController> logger,
                               ITransient transient,
                               IScoped scoped,
                               ISinglenton singlenton)
        {
            _logger = logger;
            _transient = transient;
            _scoped = scoped;
            _singlenton = singlenton;
        }

        public IActionResult Index()
        {
            ViewBag.transient = _transient;
            ViewBag.scoped = _scoped;
            ViewBag.Singlenton = _singlenton;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
