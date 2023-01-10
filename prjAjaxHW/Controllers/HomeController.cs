﻿using Microsoft.AspNetCore.Mvc;
using prjAjaxHW.Models;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace prjAjaxHW.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DemoContext _context;

        public HomeController(ILogger<HomeController> logger, DemoContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
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

        public IActionResult travel()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }

       public IActionResult addess()
        {
            return View();
        }

    }
}