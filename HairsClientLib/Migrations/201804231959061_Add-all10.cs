namespace HairsClientLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addall10 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.tblResearch", "ResearchStatusId", "dbo.tblResearchStatus");
            DropForeignKey("dbo.tblResearch", "ResearchTypeId", "dbo.tblResearchType");
            DropIndex("dbo.tblResearch", new[] { "ResearchTypeId" });
            DropIndex("dbo.tblResearch", new[] { "ResearchStatusId" });
            RenameColumn(table: "dbo.tblResearch", name: "ResearchStatusId", newName: "ResearchStatuses_Id");
            RenameColumn(table: "dbo.tblResearch", name: "ResearchTypeId", newName: "ResearchType_Id");
            AlterColumn("dbo.tblResearch", "ResearchType_Id", c => c.Int());
            AlterColumn("dbo.tblResearch", "ResearchStatuses_Id", c => c.Int());
            CreateIndex("dbo.tblResearch", "ResearchStatuses_Id");
            CreateIndex("dbo.tblResearch", "ResearchType_Id");
            AddForeignKey("dbo.tblResearch", "ResearchStatuses_Id", "dbo.tblResearchStatus", "Id");
            AddForeignKey("dbo.tblResearch", "ResearchType_Id", "dbo.tblResearchType", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblResearch", "ResearchType_Id", "dbo.tblResearchType");
            DropForeignKey("dbo.tblResearch", "ResearchStatuses_Id", "dbo.tblResearchStatus");
            DropIndex("dbo.tblResearch", new[] { "ResearchType_Id" });
            DropIndex("dbo.tblResearch", new[] { "ResearchStatuses_Id" });
            AlterColumn("dbo.tblResearch", "ResearchStatuses_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.tblResearch", "ResearchType_Id", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.tblResearch", name: "ResearchType_Id", newName: "ResearchTypeId");
            RenameColumn(table: "dbo.tblResearch", name: "ResearchStatuses_Id", newName: "ResearchStatusId");
            CreateIndex("dbo.tblResearch", "ResearchStatusId");
            CreateIndex("dbo.tblResearch", "ResearchTypeId");
            AddForeignKey("dbo.tblResearch", "ResearchTypeId", "dbo.tblResearchType", "Id", cascadeDelete: true);
            AddForeignKey("dbo.tblResearch", "ResearchStatusId", "dbo.tblResearchStatus", "Id", cascadeDelete: true);
        }
    }
}
