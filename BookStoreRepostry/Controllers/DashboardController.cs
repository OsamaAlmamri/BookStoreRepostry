﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreRepostry.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View("../Dashboard/Index");
        }
    }
}