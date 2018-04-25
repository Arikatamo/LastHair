namespace HairsClientLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addall9 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.tblImageLogo", "ReportTemplate_Id", "dbo.tblReportTemplate");
            DropIndex("dbo.tblImageLogo", new[] { "ReportTemplate_Id" });
            RenameColumn(table: "dbo.tblImageLogo", name: "ReportTemplate_Id", newName: "RepTemplate_Id");
            AlterColumn("dbo.tblImageLogo", "RepTemplate_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.tblImageLogo", "RepTemplate_Id");
            AddForeignKey("dbo.tblImageLogo", "RepTemplate_Id", "dbo.tblReportTemplate", "Id", cascadeDelete: true);
            DropColumn("dbo.tblReportTemplate", "ImgID");
            DropColumn("dbo.tblReportTemplate", "FieldTypeId");
            DropColumn("dbo.tblReportTemplate", "ReportFieldId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tblReportTemplate", "ReportFieldId", c => c.Int(nullable: false));
            AddColumn("dbo.tblReportTemplate", "FieldTypeId", c => c.Int(nullable: false));
            AddColumn("dbo.tblReportTemplate", "ImgID", c => c.Int(nullable: false));
            DropForeignKey("dbo.tblImageLogo", "RepTemplate_Id", "dbo.tblReportTemplate");
            DropIndex("dbo.tblImageLogo", new[] { "RepTemplate_Id" });
            AlterColumn("dbo.tblImageLogo", "RepTemplate_Id", c => c.Int());
            RenameColumn(table: "dbo.tblImageLogo", name: "RepTemplate_Id", newName: "ReportTemplate_Id");
            CreateIndex("dbo.tblImageLogo", "ReportTemplate_Id");
            AddForeignKey("dbo.tblImageLogo", "ReportTemplate_Id", "dbo.tblReportTemplate", "Id");
        }
    }
}
