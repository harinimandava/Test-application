using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class EmpController : Controller
    {
        public IActionResult Index()

        {
            var details = new WebApplication2.Models.HomePageViewModel.Emp(){ Name = "Harini", Gender = "Female", ID = 101 };

            ViewData["Emp"] = details;

            return View();
        }
    }
}