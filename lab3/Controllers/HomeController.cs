using lab3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using lab3.Services;

namespace lab3.Controllers
{
    public class HomeController : Controller
    {
        private readonly TimeService _timeService;
        private readonly CalcService _calcService;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, TimeService timeService, CalcService calcService)
        {
            _logger = logger;
            _timeService = timeService;
            _calcService = calcService;
        }

        public IActionResult Index()
        {
            string timeMessage = _timeService.TimeAnalysis();

            ViewData["TimeMessage"] = timeMessage;

            double num1 = 6;
            double num2 = 2;

            ViewData["AddResult"] = _calcService.Add(num1, num2);
            ViewData["SubtractResult"] = _calcService.Subtract(num1, num2);
            ViewData["MultiplyResult"] = _calcService.Multiply(num1, num2);
            ViewData["DivideResult"] = _calcService.Divide(num1, num2); 
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult TimeAnalysis()
        {
            string timeMessage = _timeService.TimeAnalysis();
            return Ok(timeMessage); 
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
