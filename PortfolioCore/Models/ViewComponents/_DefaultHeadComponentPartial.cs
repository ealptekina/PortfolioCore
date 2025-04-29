using Microsoft.AspNetCore.Mvc;

namespace PortfolioCore.Models.ViewComponents
{
    public class _DefaultHeadComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
