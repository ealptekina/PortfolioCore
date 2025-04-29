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

🗄️ Veritabanı Yapısı

Projede MSSQL Server kullanılmış ve Entity Framework Core'un Code First yaklaşımı tercih edilerek veritabanı tabloları otomatik olarak oluşturulmuştur. Başlıca tablolar şunlardır:

Abouts → Hakkımda bilgileri
Contacts → Ziyaretçilerden gelen iletişim formları
Educations → Eğitim geçmişi
Experiences → İş ve staj deneyimleri
Portfolios → Yapılan projelerin listesi
Skills → Teknik ve kişisel yetenekler
Statistics → Sitede gösterilen sayısal veriler (tamamlanan proje sayısı vb.)
Testimonials → Referanslar ve yorumlar

Categories → Kategoriler ile portföyler arasındaki ilişkiyi yönetmek için kullanılan ilişkilendirilmiş tablo (many-to-many ilişki)

🔹 Tüm tablolar arasında doğrudan ilişki bulunmamaktadır, her biri bağımsız veri girişleri için tasarlanmıştır, ancak Categories ve Portfolios tablosu gibi ilişkisel tablolar, bazı tablolar arasında ilişki kurmaktadır.
🔹 Migration yönetimi sayesinde, veri yapısında değişiklik gerektiğinde kolayca güncellemeler yapılabilir.
🔹 Admin paneli üzerinden bu tablolarla ilgili CRUD (Create, Read, Update, Delete) işlemleri gerçekleştirilebilmektedir.



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

🔹 Kullanıcı Arayüzü (UI) Bölümü:

![image](https://github.com/user-attachments/assets/de7c486c-b128-4089-a79d-8ef2c6a473c8)

![image](https://github.com/user-attachments/assets/46b8de1f-9857-46e4-84a5-e166d4f602e4)

![image](https://github.com/user-attachments/assets/a0fafb00-ae6a-4480-a0ac-d6cdfb26dc7b)

![image](https://github.com/user-attachments/assets/1c91cc46-c677-4107-85b2-b1f7709aa8c8)

![image](https://github.com/user-attachments/assets/20cbfbee-0a05-41ec-b9c5-aef48f64586e)

![image](https://github.com/user-attachments/assets/5498e64b-8786-431a-968c-c75b8db7ea6d)

![image](https://github.com/user-attachments/assets/0d8a67bc-f78c-418d-af64-4b4b9ffafa6c)

![image](https://github.com/user-attachments/assets/e306b59f-d62c-462c-88fa-2eeccb15c0ae)

![image](https://github.com/user-attachments/assets/f071ae75-eb10-4901-907c-68167ddc71c9)

![image](https://github.com/user-attachments/assets/2867c82e-6dff-4418-a93f-dfd0ebcd60fc)

![image](https://github.com/user-attachments/assets/073369fe-eabc-4c22-9530-939482fa018b)


🔹 Yönetim (Admin) Paneli:

![image](https://github.com/user-attachments/assets/869e2c3b-524c-41cc-9a54-14adb6637480)

![image](https://github.com/user-attachments/assets/1af066b4-e320-42c5-9150-0b9a5a517343)

![image](https://github.com/user-attachments/assets/4ea98e49-d518-45d4-98bf-2c8f98e99dac)

![image](https://github.com/user-attachments/assets/36eff55a-c4a8-4522-95c5-973036b7088c)

![image](https://github.com/user-attachments/assets/a29c934d-71fa-4440-a57f-17e3119c8c1b)

![image](https://github.com/user-attachments/assets/47812b36-422b-4f54-8032-8b1d5ee0fe2f)

![image](https://github.com/user-attachments/assets/87aa06c8-994c-49ab-bdb2-ca40bbc283e0)

![image](https://github.com/user-attachments/assets/1af3a2c9-793a-4e44-8d3c-daee2bcf728f)

![image](https://github.com/user-attachments/assets/40e45b88-5d56-452a-b818-00ca49038596)

![image](https://github.com/user-attachments/assets/fb93dfec-c742-46bc-913d-26963d5d2bd6)

![image](https://github.com/user-attachments/assets/9d2621c7-18f2-4698-9cbf-66e9f036797c)

![image](https://github.com/user-attachments/assets/e0b95d90-1c05-4f0a-85d5-8905b516da5c)

![image](https://github.com/user-attachments/assets/386dad57-07f1-481d-aa9b-e645e49ed55d)

🔹 Veritabanı:

![image](https://github.com/user-attachments/assets/76a4ffbf-ae61-414b-99f7-e4d808b6d4b5)



