namespace HairsClientLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update23 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.tblReportfield", name: "ReportTemplate_Id", newName: "Template_Id");
            RenameIndex(table: "dbo.tblReportfield", name: "IX_ReportTemplate_Id", newName: "IX_Template_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.tblReportfield", name: "IX_Template_Id", newName: "IX_ReportTemplate_Id");
            RenameColumn(table: "dbo.tblReportfield", name: "Template_Id", newName: "ReportTemplate_Id");
        }
    }
}
