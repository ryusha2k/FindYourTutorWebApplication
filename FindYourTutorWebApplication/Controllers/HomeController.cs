﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FindYourTutorWebApp.Models;

namespace FindYourTutorWebApp.Controllers
{
    public class HomeController : Controller
    {        
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Reviews()
        {
            return View();
        }
        public IActionResult Search()
        {
            return View();
        }
        public IActionResult Sign()
        {
            return View();
        }
    }
}
