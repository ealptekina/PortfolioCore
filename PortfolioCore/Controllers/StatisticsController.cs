using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;
using System.Linq;

namespace PortfolioCore.Controllers
{
    public class StatisticsController : Controller
    {
        PortfolioContext context = new PortfolioContext();

        public IActionResult Index()
        {
            // v1: Toplam yetenek sayısı
            ViewBag.v1 = context.Skills.Count();

            // v2: Yetenek değerlerinin toplamı
            ViewBag.v2 = context.Skills.Sum(x => x.SkillValue);

            // v3: Değeri 70 ve üzeri yetenek sayısı
            ViewBag.v3 = context.Skills.Count(x => x.SkillValue >= 70);

            // v4: Yeteneklerin ortalama puanı
            ViewBag.v4 = context.Skills.Average(x => x.SkillValue);

            // v5: Toplam deneyim sayısı
            ViewBag.v5 = context.Experiences.Count();

            // v6: "Developer" unvanlı deneyimlerin sayısı
            ViewBag.v6 = context.Experiences.Count(x => x.SubTitle == "Developer");

            // v7: En yüksek puanlı yetenek
            var highestSkill = context.Skills.OrderByDescending(x => x.SkillValue).FirstOrDefault();
            ViewBag.v7 = highestSkill != null ? highestSkill.SkillName + " - " + highestSkill.SkillValue : "Veri Yok";

            // v8: En düşük puanlı yetenek
            var lowestSkill = context.Skills.OrderBy(x => x.SkillValue).FirstOrDefault();
            ViewBag.v8 = lowestSkill != null ? lowestSkill.SkillName + " - " + lowestSkill.SkillValue : "Veri Yok";

            // v9: Toplam proje sayısı (Deneyim sayısını proje gibi alıyorsan)
            ViewBag.v9 = context.Experiences.Count();

            // v10: Son eklenen yetenek
            var lastSkill = context.Skills.OrderByDescending(x => x.SkillId).FirstOrDefault(); // SkillId'ye göre
            ViewBag.v10 = lastSkill != null ? lastSkill.SkillName : "Veri Yok";

            return View();
        }
    }
}
