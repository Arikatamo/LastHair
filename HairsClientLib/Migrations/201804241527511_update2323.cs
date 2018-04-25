namespace HairsClientLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update2323 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.tblResearch", "ResearchStatuses_Id", "dbo.tblResearchType");
            DropForeignKey("dbo.tblResearch", "ResearchType_Id1", "dbo.tblResearchType");
            DropForeignKey("dbo.tblResearch", "ResearchType_Id", "dbo.tblResearchType");
            DropForeignKey("dbo.tblResearch", "ResearStatus_Id", "dbo.tblResearchStatus");
            DropIndex("dbo.tblResearch", new[] { "ResearchType_Id" });
            DropIndex("dbo.tblResearch", new[] { "ResearchStatuses_Id" });
            DropIndex("dbo.tblResearch", new[] { "ResearchType_Id1" });
            DropIndex("dbo.tblResearch", new[] { "ResearStatus_Id" });
            DropColumn("dbo.tblResearch", "ResearchType_Id");
            DropColumn("dbo.tblResearch", "ResearchStatuses_Id");
            RenameColumn(table: "dbo.tblResearch", name: "ResearchType_Id1", newName: "ResearchType_Id");
            RenameColumn(table: "dbo.tblResearch", name: "ResearStatus_Id", newName: "ResearchStatuses_Id");
            AlterColumn("dbo.tblResearch", "ResearchType_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.tblResearch", "ResearchStatuses_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.tblResearch", "ResearchType_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.tblResearch", "ResearchStatuses_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.tblResearch", "ResearchStatuses_Id");
            CreateIndex("dbo.tblResearch", "ResearchType_Id");
            AddForeignKey("dbo.tblResearch", "ResearchStatuses_Id", "dbo.tblResearchStatus", "Id", cascadeDelete: true);
            AddForeignKey("dbo.tblResearch", "ResearchType_Id", "dbo.tblResearchType", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblResearch", "ResearchType_Id", "dbo.tblResearchType");
            DropForeignKey("dbo.tblResearch", "ResearchStatuses_Id", "dbo.tblResearchStatus");
            DropIndex("dbo.tblResearch", new[] { "ResearchType_Id" });
            DropIndex("dbo.tblResearch", new[] { "ResearchStatuses_Id" });
            AlterColumn("dbo.tblResearch", "ResearchStatuses_Id", c => c.Int());
            AlterColumn("dbo.tblResearch", "ResearchType_Id", c => c.Int());
            AlterColumn("dbo.tblResearch", "ResearchStatuses_Id", c => c.Int());
            AlterColumn("dbo.tblResearch", "ResearchType_Id", c => c.Int());
            RenameColumn(table: "dbo.tblResearch", name: "ResearchStatuses_Id", newName: "ResearStatus_Id");
            RenameColumn(table: "dbo.tblResearch", name: "ResearchType_Id", newName: "ResearchType_Id1");
            AddColumn("dbo.tblResearch", "ResearchStatuses_Id", c => c.Int());
            AddColumn("dbo.tblResearch", "ResearchType_Id", c => c.Int());
            CreateIndex("dbo.tblResearch", "ResearStatus_Id");
            CreateIndex("dbo.tblResearch", "ResearchType_Id1");
            CreateIndex("dbo.tblResearch", "ResearchStatuses_Id");
            CreateIndex("dbo.tblResearch", "ResearchType_Id");
            AddForeignKey("dbo.tblResearch", "ResearStatus_Id", "dbo.tblResearchStatus", "Id");
            AddForeignKey("dbo.tblResearch", "ResearchType_Id", "dbo.tblResearchType", "Id");
            AddForeignKey("dbo.tblResearch", "ResearchType_Id1", "dbo.tblResearchType", "Id");
            AddForeignKey("dbo.tblResearch", "ResearchStatuses_Id", "dbo.tblResearchType", "Id");
        }
    }
}
