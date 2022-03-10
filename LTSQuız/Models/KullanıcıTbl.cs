using System.ComponentModel.DataAnnotations;

namespace LTSQuız.Models
{
    public class KullanıcıTbl
    {
        [Key]
        public int UserID { get; set; }

        [Required(ErrorMessage = "{0} gerekli."), Display(Name = "Ad"), StringLength(40, MinimumLength = 2, ErrorMessage = "{0} en az {2} en fazla {1} karakter olabilir.")]
        public string Ad { get; set; }
        [Required(ErrorMessage = "{0} gerekli."), Display(Name = "Soyad"), StringLength(30, MinimumLength = 2, ErrorMessage = "{0} en az {2} en fazla {1} karakter olabilir.")]
        public string Soyad { get; set; }

        [Required(ErrorMessage = "{0} Gerekli."), Display(Name = "KullaniciAdi")]
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string Email { get; set; }
        public string TelefonNo { get; set; }

        public string TamAdı
        {
            get
            {
                return Ad + " " + Soyad;
            }
        }


        
    }
}
