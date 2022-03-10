using System.ComponentModel.DataAnnotations;

namespace LTSQuız.Models
{
    public class HesapKartTbl
    {
        [Key]
        public int KartID { get; set; }
        public string Unvan { get; set; }
        public string VergiDairesi { get; set; }
        public int VergiNo { get; set; }
        public int Tc { get; set; }

        [Required(ErrorMessage = "{0} gerekli."), Display(Name = "Adres"), StringLength(200, MinimumLength = 2, ErrorMessage = "{0} en az {2} en fazla {1} karakter olabilir.")]
        public string Adres { get; set; }
        public int TipID { get; set; }
        public int TurID { get; set; }
        public int GrupID { get; set; }
        public int AltGrupID { get; set; }

      

    }
}
