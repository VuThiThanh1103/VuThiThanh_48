namespace VuThiThanh_48.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_NhanVien : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NhanViens",
                c => new
                    {
                        MaNhanVien = c.String(nullable: false, maxLength: 128),
                        TenNhanVien = c.String(),
                        MaTinhThanh = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaNhanVien)
                .ForeignKey("dbo.TinhThanhs", t => t.MaTinhThanh, cascadeDelete: true)
                .Index(t => t.MaTinhThanh);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NhanViens", "MaTinhThanh", "dbo.TinhThanhs");
            DropIndex("dbo.NhanViens", new[] { "MaTinhThanh" });
            DropTable("dbo.NhanViens");
        }
    }
}
