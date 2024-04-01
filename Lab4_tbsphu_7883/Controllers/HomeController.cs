using Lab4_tbsphu_7883.Data;
using Lab4_tbsphu_7883.Models;
using Lab4_tbsphu_7883.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Lab4_tbsphu_7883.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
    }
}
