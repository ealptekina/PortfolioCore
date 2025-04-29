using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;

namespace PortfolioCore.Models.ViewComponents
{
    public class _DefaultServiceComponentPartial: ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            // ServiceId'ye göre azalan sırayla sıralar ve son 6 kaydı alır.
            var value = context.Services
                                .OrderByDescending(x => x.ServiceId)
                                .Take(6)
                                .ToList();
            return View(value);
        }
    }
}
