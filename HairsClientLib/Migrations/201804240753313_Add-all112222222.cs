namespace HairsClientLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addall112222222 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.tblReportTemplate", "User_Id", "dbo.tblUser");
            DropForeignKey("dbo.tblResearch", "ResearchStatuses_Id", "dbo.tblResearchStatus");
            DropForeignKey("dbo.tblResearch", "ResearchType_Id", "dbo.tblResearchType");
            DropIndex("dbo.tblResearch", new[] { "ResearchStatuses_Id" });
            DropIndex("dbo.tblResearch", new[] { "ResearchType_Id" });
            DropIndex("dbo.tblReportTemplate", new[] { "User_Id" });
            AlterColumn("dbo.tblResearch", "ResearchStatuses_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.tblResearch", "ResearchType_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.tblReportTemplate", "User_Id", c => c.Int());
            CreateIndex("dbo.tblResearch", "ResearchStatuses_Id");
            CreateIndex("dbo.tblResearch", "ResearchType_Id");
            CreateIndex("dbo.tblReportTemplate", "User_Id");
            AddForeignKey("dbo.tblReportTemplate", "User_Id", "dbo.tblUser", "Id");
            AddForeignKey("dbo.tblResearch", "ResearchStatuses_Id", "dbo.tblResearchStatus", "Id", cascadeDelete: true);
            AddForeignKey("dbo.tblResearch", "ResearchType_Id", "dbo.tblResearchType", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblResearch", "ResearchType_Id", "dbo.tblResearchType");
            DropForeignKey("dbo.tblResearch", "ResearchStatuses_Id", "dbo.tblResearchStatus");
            DropForeignKey("dbo.tblReportTemplate", "User_Id", "dbo.tblUser");
            DropIndex("dbo.tblReportTemplate", new[] { "User_Id" });
            DropIndex("dbo.tblResearch", new[] { "ResearchType_Id" });
            DropIndex("dbo.tblResearch", new[] { "ResearchStatuses_Id" });
            AlterColumn("dbo.tblReportTemplate", "User_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.tblResearch", "ResearchType_Id", c => c.Int());
            AlterColumn("dbo.tblResearch", "ResearchStatuses_Id", c => c.Int());
            CreateIndex("dbo.tblReportTemplate", "User_Id");
            CreateIndex("dbo.tblResearch", "ResearchType_Id");
            CreateIndex("dbo.tblResearch", "ResearchStatuses_Id");
            AddForeignKey("dbo.tblResearch", "ResearchType_Id", "dbo.tblResearchType", "Id");
            AddForeignKey("dbo.tblResearch", "ResearchStatuses_Id", "dbo.tblResearchStatus", "Id");
            AddForeignKey("dbo.tblReportTemplate", "User_Id", "dbo.tblUser", "Id", cascadeDelete: true);
        }
    }
}
