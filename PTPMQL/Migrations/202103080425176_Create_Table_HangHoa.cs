namespace PTPMQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_HangHoa : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HangHoas",
                c => new
                    {
                        IDHang = c.String(nullable: false, maxLength: 128),
                        TenHang = c.String(),
                        DonVi = c.String(),
                        SoLuongCon = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IDHang);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.HangHoas");
        }
    }
}
