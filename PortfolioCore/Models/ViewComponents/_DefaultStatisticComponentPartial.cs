using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;
using System;

namespace PortfolioCore.Models.ViewComponents
{
    public class _DefaultStatisticComponentPartial : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = context.Testimonials.Count(); // Referans sayısı
            ViewBag.v2 = context.Portfolios.Count();   // Portfolyo sayısı
            ViewBag.v3 = context.Skills.Count();        // Yetenek sayısı

            Random rnd = new Random();
            ViewBag.v4 = rnd.Next(10, 21); // 10 ile 20 arasında rastgele sayı (üst sınır 21 olmalı!)

            return View();
        }
    }
}
