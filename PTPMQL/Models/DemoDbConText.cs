using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PTPMQL.Models
{
    public partial class DemoDbConText : DbContext
    {
        public DemoDbConText()
            : base("name=DemoDbConText")
        {
        }
        public virtual DbSet <HangHoa> HangHoas { get; set; }
        public virtual DbSet <HoaDonBan> HoaDonBans { get; set; }
        public virtual DbSet <PhieuXuat> PhieuXuats { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
