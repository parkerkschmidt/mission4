using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mission4.Models;

namespace mission4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private MovieResponseContext BlahContext { get; set; }

        public HomeController(ILogger<HomeController> logger, MovieResponseContext someName)
        {
            _logger = logger;
            BlahContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Podcasts()
        {
            return View();
        }

        [HttpGet]
        public IActionResult FilmForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FilmForm(MovieResponse response)
        {
            BlahContext.Add(response);
            BlahContext.SaveChanges();

            return View("Confirmation", response);

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
