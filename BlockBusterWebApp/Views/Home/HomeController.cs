using Abp.Web.Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BlockBusterWebApp.Pages
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Colors()
        {
            string[] colors = {"Red", "Blue", "Yellow"};
            ViewBag.Colors = colors;
            return View();
        }

        public IActionResult Hobbies()
        {
            string[] hobbyList = { "Sleep", "Eat", "Breath", "Live", "Sleep again" };
            ViewBag.Hobbies = hobbyList;
            return View();
        }

        public IActionResult Cities()
        {
            string[] cityList = { "Red City", "Blue City", "Yellow City", "Green City", "Beige City"};
            ViewBag.Cities = cityList;
            return View();
        }
    }
}
