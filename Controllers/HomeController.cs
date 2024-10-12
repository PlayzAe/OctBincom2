using Microsoft.AspNetCore.Mvc;
using MyOnlineCV.Models;

namespace MyOnlineCV.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Projects()
        {
            return View();
        }



        // This action will handle both GET (load the page) and POST (form submission)
        [HttpGet]
        public IActionResult TaxCalculator()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TaxCalculator(decimal income)
        {
            // fix this error //
            var model = new TaxCalculatorModel { Income = income };
            var max = model.CalculateTax();

            // Format the tax with commas and send it to the ViewBag
            ViewBag.Tax = max.ToString("N2"); // N2: Number with 2 decimal places and commas

            // Simple tax calculation logic for Nigeria
            decimal tax = 0;
            if (income <= 300000)
            {
                tax = income * 0.07m; // 7% tax for low-income
            }
            else if (income <= 600000)
            {
                tax = income * 0.11m; // 11% tax for middle-income
            }
            else
            {
                tax = income * 0.24m; // 24% tax for high-income
            }

            // Store the calculated tax in ViewBag to display on the view
            ViewBag.Tax = tax;
            return View();
        }
    }
}
