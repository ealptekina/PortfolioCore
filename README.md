📚 PortfolioCore Projesi

Merhaba! 👋
PortfolioCore, ASP.NET Core MVC teknolojisi kullanılarak geliştirilen, tamamen dinamik yapıya sahip bir kişisel portföy yönetim sistemidir.
Bu proje ile hem yazılım geliştirme yeteneklerimi sergilemeyi hem de etkili bir şekilde portföy yönetimi sağlamayı amaçladım.

🚀 Kullanılan Teknolojiler ve Araçlar

🔹 ASP.NET Core MVC: Modern web uygulamaları geliştirmek için güçlü bir framework.
🔹 Entity Framework Core: Code First yaklaşımıyla MSSQL veritabanı yönetimi.
🔹 Partial View: Sayfaları modüler yaparak kodun daha okunabilir ve yönetilebilir olmasını sağladım.
🔹 ViewComponent: Sayfa içerisinde veri tabanıyla dinamik veri çekerek bağımsız bileşenler oluşturuldu.
🔹 Tek Katmanlı Mimari: Hızlı geliştirme ve sade bir yapı için tercih edildi.
🔹 MSSQL: Projenin veritabanı yönetim sistemi olarak kullanıldı.
🔹 Bootstrap ve Custom CSS: Responsive tasarım ve kullanıcı dostu arayüzler için kullanıldı.

📂 Proje Yapısı

Context
➔ Veritabanı bağlantıları ve konfigürasyon ayarlarının yapıldığı sınıflar.

Controllers
➔ MVC Controller'lar aracılığıyla veri akışı ve iş mantığı yönetimi.

Entities
➔ Veritabanı tablolarını temsil eden temel veri model sınıfları.

Migrations
➔ Entity Framework ile veritabanı güncellemelerinin takip edildiği bölüm.

Models
➔ ViewModel'ler ve veri transfer nesneleri burada bulunur.

Views
➔ Razor View yapısı ile oluşturulmuş kullanıcı arayüzü dosyaları:
   • Ana Sayfa (Home)
   • Hakkımda (About)
   • İletişim (Contact)
   • Eğitim (Education)
   • Tecrübeler (Experience)
   • Portföy (Portfolio)
   • Yetenekler (Skill)
   • İstatistikler (Statistics)
➔ Ayrıca Admin tarafına özel layout ve yönetim ekranları yer almaktadır.

wwwroot
➔ CSS, JavaScript dosyaları ve görseller gibi tüm statik içeriklerin bulunduğu klasör.

Program.cs / appsettings.json
➔ Uygulamanın başlatılması ve yapılandırılması için gerekli ayar dosyaları.

📋 Projedeki Temel Özellikler

✅ Dinamik olarak veritabanı ile iletişim kurarak içeriklerin yönetimi.
✅ Admin paneli üzerinden içerik ekleme, düzenleme ve silme (CRUD işlemleri).
✅ Kullanıcıların portföyünüzü profesyonel bir şekilde inceleyebileceği modern arayüz.
✅ ViewComponent yapısıyla sayfalarda performanslı veri sunumu.
✅ PartialView ve Layout kullanımı ile minimum kod tekrarı ve maksimum kod okunabilirliği.
✅ Responsive tasarım desteği ile tüm cihazlarda uyumlu görüntülenme.
✅ Temiz mimari yapısı ve geliştirilebilir proje altyapısı.

📌 Neden Bu Projeyi Yaptım?

Bu projeyi geliştirerek, MVC mimarisinin dinamik veri işlemleri üzerindeki gücünü göstermek ve gerçek bir portföy uygulaması deneyimi sunmak istedim.
Aynı zamanda Entity Framework Core, ViewComponent ve ASP.NET Core'un sunduğu özelliklerle geliştirilebilir ve sürdürülebilir bir yazılım altyapısı oluşturmayı hedefledim.
