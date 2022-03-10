using System.ComponentModel.DataAnnotations;

namespace LTSQuız.Models
{
    public class HesapKartAltGrupTbl
    {
        [Key]
        public int AltGrupID { get; set; }

        HesapKartGrupTbl HesapKartGrupTbl { get; set; }
        public string AltGrupAdi{ get; set; }

      
    }
}
