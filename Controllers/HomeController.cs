using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BcseByService.Models;

namespace BcseByService.Controllers
{
    public class HomeController : Controller
    {
        [HttpPost]
        public void SendEmail(string surname, string name, string patronymic, 
        string organization, string position, string address,string email,string phone)
        {

            //https://stackoverflow.com/questions/32260/sending-email-in-net-through-gmail 
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
