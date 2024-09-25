using lab3.Services;
using Microsoft.AspNetCore.Mvc;

namespace lab3.Controllers
{
    public class CalcController : Controller
    {
        private CalcService _calcService;

        public CalcController()
        {
            _calcService = new CalcService();
        }
       
        [HttpGet]
        public IActionResult Add()
        {
            return Ok(_calcService.Add(6,2)); 
        }

        [HttpGet]
        public IActionResult Subtract()
        {
            return Ok(_calcService.Subtract(6,2)); 
        }

        [HttpGet]
        public IActionResult Multiply()
        {
            return Ok(_calcService.Multiply(6,2)); 
        }

        [HttpGet]
        public IActionResult Divide()
        {
                return Ok(_calcService.Divide(6,2)); 
        }
        
        [HttpGet]
        public IActionResult Calculate()
        {
            return View(); 
        }
    }
}
