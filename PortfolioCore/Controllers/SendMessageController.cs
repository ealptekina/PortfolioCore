using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;
using PortfolioCore.Entities;

namespace PortfolioCore.Controllers
{
    public class SendMessageController : Controller
    {
        PortfolioContext context = new PortfolioContext();

        [HttpPost]
        public IActionResult Index(Message message)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    // Mesajı veritabanına ekliyoruz
                    context.Messages.Add(message);
                    context.SaveChanges();

                    // Başarı mesajı ayarlanıyor
                    ViewBag.Success = "Gönderim işlemi başarılı!";

                    return View("~/Views/Default/Index.cshtml");
                }
                catch (Exception ex)
                {
                    ViewBag.Error = $"Bir hata oluştu: {ex.Message}";
                    return View("~/Views/Default/Index.cshtml");
                }
            }

            ViewBag.Error = "Lütfen tüm alanları doğru şekilde doldurduğunuzdan emin olun.";
            return View("~/Views/Default/Index.cshtml");
        }
    }
}
