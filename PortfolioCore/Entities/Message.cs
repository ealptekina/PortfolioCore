using System.ComponentModel.DataAnnotations;

namespace PortfolioCore.Entities
{
    public class Message
    {
        public int MessageId { get; set; }

        [Required(ErrorMessage = "Ad ve soyad zorunludur.")]
        [MaxLength(100, ErrorMessage = "Ad ve soyad en fazla 100 karakter olabilir.")]
        public string NameSurname { get; set; }

        [Required(ErrorMessage = "E-posta adresi zorunludur.")]
        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi giriniz.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Konu alanı zorunludur.")]
        [MaxLength(150, ErrorMessage = "Konu en fazla 150 karakter olabilir.")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Mesaj detayı zorunludur.")]
        [MaxLength(1000, ErrorMessage = "Mesaj en fazla 1000 karakter olabilir.")]
        public string MessageDetail { get; set; }

        public DateTime SendDate { get; set; } = DateTime.Now; // Gönderim zamanı otomatik atanır
        public bool IsRead { get; set; } = false; // İlk gönderim durumunda okunmamış olarak ayarlanır
    }
}
