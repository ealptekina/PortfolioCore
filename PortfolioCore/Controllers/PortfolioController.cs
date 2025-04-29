using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PortfolioCore.Context;
using PortfolioCore.Entities;

namespace PortfolioCore.Controllers
{
    public class PortfolioController : Controller
    {
        // DbContext nesnesi oluşturuluyor
        PortfolioContext context = new PortfolioContext();

        // Portföy listesi sayfası için veritabanındaki Portfolyo ve ilişkili Category verilerini alıyoruz
        public IActionResult PortfolioList()
        {
            // Portfolyoları ve her portföyün bağlı olduğu kategoriyi almak için Include kullanıyoruz
            var value = context.Portfolios.Include(x => x.Category).ToList();

            // Veriyi View'a gönderiyoruz
            return View(value);
        }

        // Yeni portföy oluşturmak için kullanılan GET metodudur
        [HttpGet]
        public IActionResult CreatePortfolio()
        {
            // Tüm kategorileri almak ve bunları SelectList olarak View'da dropdown olarak gösterebilmek için
            var value = new SelectList(context.Categories.ToList(), "CategoryId", "CategoryName");

            // Kategorileri ViewBag ile View'a gönderiyoruz
            ViewBag.v = value;
            return View();
        }

        // Yeni portföy oluşturmak için kullanılan POST metodudur
        [HttpPost]
        public IActionResult CreatePortfolio(Portfolio port)
        {
            // Yeni portföyü Portfolios tablosuna ekliyoruz
            context.Portfolios.Add(port);

            // Değişiklikleri veritabanına kaydediyoruz
            context.SaveChanges();

            // Portföy listesine yönlendirme yapıyoruz
            return RedirectToAction("PortfolioList");
        }

        [HttpGet]
        public IActionResult UpdatePortfolio(int id)
        {
            var value = context.Portfolios.Find(id);

            ViewBag.v = new SelectList(context.Categories.ToList(), "CategoryId", "CategoryName", value.CategoryId);

            return View(value);
        }

        [HttpPost]
        public IActionResult UpdatePortfolio(Portfolio portfolio)
        {
            // Proje Resmi URL'si kontrolü
            if (!string.IsNullOrEmpty(portfolio.ImageUrl) &&
                !portfolio.ImageUrl.StartsWith("http://") &&
                !portfolio.ImageUrl.StartsWith("https://"))
            {
                // Site adresini ekleyerek tam bir URL yapıyoruz
                portfolio.ImageUrl = "https://localhost:7148/" + portfolio.ImageUrl;
            }

            // Güncelleme işlemi
            context.Portfolios.Update(portfolio);
            context.SaveChanges();
            return RedirectToAction("PortfolioList");
        }



        public IActionResult DeletePortfolio(int id)
        {
            var value = context.Portfolios.Find(id);
            context.Portfolios.Remove(value);
            context.SaveChanges();
            return RedirectToAction("PortfolioList");
        }
    }
}
