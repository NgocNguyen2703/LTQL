using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PTPMQL.Models
{
    [Table("HangHoas")]
    public class HangHoa
    {
        [Key]
        public string IDHang { get; set; }
        public string TenHang { get; set; }
        public string DonVi { get; set; }
        public int SoLuongCon { get; set; }
    }
}