using FinalWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FinalWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.ServerTime = DateTime.Now;
            return View();
        }
    }
}