using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HouseReception.Models;
using Microsoft.AspNetCore.Mvc;

namespace HouseReception.Controllers
{
    public class PageListController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }
    }
}
