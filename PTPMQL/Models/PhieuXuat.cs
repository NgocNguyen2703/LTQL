using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PTPMQL.Models
{
    [Table("PhieuXuats")]
    public class PhieuXuat
    {
        [Key]
        public String IDHoaDon { get; set; }
        public String IDHang { get; set; }
        public String DonGia { get; set; }
        public int SoLuongBan { get; set; }

    }
}