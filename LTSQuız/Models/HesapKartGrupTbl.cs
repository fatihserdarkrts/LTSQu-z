using System.ComponentModel.DataAnnotations;

namespace LTSQuız.Models
{
    public class HesapKartGrupTbl
    {
        [Key]
        public int GrupID { get; set; }
        public string GrupAdi{ get; set; }

    
    }
}
