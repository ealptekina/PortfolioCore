using Microsoft.AspNetCore.Mvc;

namespace PortfolioCore.Models.ViewComponents
{
    public class _DefaultSidebarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
