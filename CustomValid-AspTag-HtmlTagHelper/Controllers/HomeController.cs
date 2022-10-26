using CustomValid_AspTag_HtmlTagHelper.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CustomValid_AspTag_HtmlTagHelper.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        /*
         * Customer sınıfı oluşturunuz
         * customerID, CompanyName, Age, Email, JoinDate, Enum CustomerType => New=0, Regular, Elite
         * Required, Error Message
        */
        public IActionResult CustomerDetails()
        {
            return View();
        }
    }
}