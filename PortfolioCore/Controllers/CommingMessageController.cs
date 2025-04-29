using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortfolioCore.Context;

namespace PortfolioCore.Controllers
{
    public class CommingMessageController : Controller
    {
        PortfolioContext context = new PortfolioContext();
        public IActionResult CommingMessageList()
        {
            var messages = context.Messages.ToList(); // Mesajları çekiyoruz
            return View(messages);
        }

        // Mesajın okunma durumunu güncelleyen metod
        [HttpPost]
        public IActionResult MarkAsRead(int messageId, bool isRead)
        {
            var message = context.Messages.Find(messageId);
            if (message != null)
            {
                message.IsRead = isRead; // IsRead durumunu güncelliyoruz
                context.SaveChanges();
            }

            return RedirectToAction("CommingMessageList"); // Listeyi yeniden yükleyip admin paneline yönlendiriyoruz
        }
    }
}
