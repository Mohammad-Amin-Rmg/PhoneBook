using Microsoft.AspNetCore.Mvc;
using PhoneBook.Domain.Contrasts.People;
using PhoneBook.Domain.Entities.People;
using PhoneBook_Project.Models;
using System.Diagnostics;

namespace PhoneBook_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPersonRespository _personRespository;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IPersonRespository personRespository)
        {
            _logger = logger;
            _personRespository = personRespository;
        }

        public IActionResult Index()
        {
            //_logger.Log(LogLevel.Information, $"Add Person in {DateTime.Now}");
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
    }
}