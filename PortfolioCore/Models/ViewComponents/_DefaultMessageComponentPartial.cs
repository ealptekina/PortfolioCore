using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Entities;

namespace PortfolioCore.Models.ViewComponents
{
    public class _DefaultMessageComponentPartial : ViewComponent
    {

        public IViewComponentResult Invoke()
        {

            return View(new Message());
        }
    }
}
