namespace HairsClientLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addall11222 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.tblReportTemplate", "User_Id", "dbo.tblUser");
            DropForeignKey("dbo.tblReportTemplate", "Research_Id", "dbo.tblResearch");
            DropIndex("dbo.tblReportTemplate", new[] { "Research_Id" });
            DropIndex("dbo.tblReportTemplate", new[] { "User_Id" });
            AlterColumn("dbo.tblReportTemplate", "Research_Id", c => c.Int());
            AlterColumn("dbo.tblReportTemplate", "User_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.tblReportTemplate", "Research_Id");
            CreateIndex("dbo.tblReportTemplate", "User_Id");
            AddForeignKey("dbo.tblReportTemplate", "User_Id", "dbo.tblUser", "Id", cascadeDelete: true);
            AddForeignKey("dbo.tblReportTemplate", "Research_Id", "dbo.tblResearch", "Id");
            DropColumn("dbo.tblUser", "ReporsId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tblUser", "ReporsId", c => c.Int(nullable: false));
            DropForeignKey("dbo.tblReportTemplate", "Research_Id", "dbo.tblResearch");
            DropForeignKey("dbo.tblReportTemplate", "User_Id", "dbo.tblUser");
            DropIndex("dbo.tblReportTemplate", new[] { "User_Id" });
            DropIndex("dbo.tblReportTemplate", new[] { "Research_Id" });
            AlterColumn("dbo.tblReportTemplate", "User_Id", c => c.Int());
            AlterColumn("dbo.tblReportTemplate", "Research_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.tblReportTemplate", "User_Id");
            CreateIndex("dbo.tblReportTemplate", "Research_Id");
            AddForeignKey("dbo.tblReportTemplate", "Research_Id", "dbo.tblResearch", "Id", cascadeDelete: true);
            AddForeignKey("dbo.tblReportTemplate", "User_Id", "dbo.tblUser", "Id");
        }
    }
}
