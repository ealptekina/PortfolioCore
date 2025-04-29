using Microsoft.AspNetCore.Mvc;

namespace PortfolioCore.Controllers
{
    public class ErrorController : Controller
    {
        // 404 sayfası için
        public IActionResult NotFound(int code)
        {
           
            return View();
        }

    }
}
