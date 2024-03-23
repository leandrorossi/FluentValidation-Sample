using FluentValidation;
using FluentValidation.Results;
using FluentValidation_Sample.Extensions;
using FluentValidation_Sample.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FluentValidation_Sample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IValidator<Customer> _validator;   

        public HomeController(ILogger<HomeController> logger, IValidator<Customer> validator)
        {
            _logger = logger;
            _validator = validator;
        }

        public IActionResult Index()
        {
            if (TempData["showCreateSuccess"] != null && TempData["showCreateSuccess"].Equals(true))
            {
                ViewData["showMessage"] = true;
            }
            else
            {
                ViewData["showMessage"] = false;
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(Customer customer)
        {
            ValidationResult result = await _validator.ValidateAsync(customer);

            if (!result.IsValid)
            {
                result.AddErrorToModelState(ModelState);
                
                ViewData["showMessage"] = false;
                return View("Index", customer);
            }

            TempData["showCreateSuccess"] = true;

            return RedirectToAction(nameof(Index));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
