﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MvcBlog.Controllers
{
    [Authorize(Roles="admin")]
    public class AdminController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
