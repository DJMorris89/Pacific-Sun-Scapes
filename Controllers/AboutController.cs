﻿using Microsoft.AspNetCore.Mvc;

namespace PacificSunscapes3.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
