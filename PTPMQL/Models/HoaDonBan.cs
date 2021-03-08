using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PTPMQL.Models
{
    [Table("HoaDonBans")]
    public class HoaDonBan
    {
        [Key]
        public string IDHoaDon { get; set; }
        public string NgayLap { get; set; }
        public string HoTenKH { get; set; }
        public string DiaChi { get; set; }
    }
}