using System.ComponentModel.DataAnnotations;

namespace LTSQuız.Models
{
    public class HesapKartTurTbl
    {
        [Key]
        public int TurID { get; set; }
        public string TurAdi { get; set; }

      
    }
}
