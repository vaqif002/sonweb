﻿using Microsoft.AspNetCore.Mvc;

namespace sonweb.Areas.Admin.Controllers
{
    
    
        public class DashboardController : Controller
        {
            [Area("Admin")]
            public IActionResult Index()
            {
                return View();
            }
        }
    
}
