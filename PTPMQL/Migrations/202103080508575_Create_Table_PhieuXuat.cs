namespace PTPMQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_PhieuXuat : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PhieuXuats",
                c => new
                    {
                        IDHoaDon = c.String(nullable: false, maxLength: 128),
                        IDHang = c.String(),
                        DonGia = c.String(),
                        SoLuongBan = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IDHoaDon);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PhieuXuats");
        }
    }
}
