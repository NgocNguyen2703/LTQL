namespace PTPMQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_HoaDonBan : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HoaDonBans",
                c => new
                    {
                        IDHoaDon = c.String(nullable: false, maxLength: 128),
                        NgayLap = c.String(),
                        HoTenKH = c.String(),
                        DiaChi = c.String(),
                    })
                .PrimaryKey(t => t.IDHoaDon);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.HoaDonBans");
        }
    }
}
