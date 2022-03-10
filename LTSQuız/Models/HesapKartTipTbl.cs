using System.ComponentModel.DataAnnotations;

namespace LTSQuız.Models
{
    public class HesapKartTipTbl
    {
        [Key]
        public int TipID { get; set; }
        public string TipAdi { get; set; }

      
    }
}
