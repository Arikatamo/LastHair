namespace HairsClientLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.tblResearch", "ResearchStatuses_Id", "dbo.tblResearchStatus");
            DropForeignKey("dbo.tblResearch", "ResearchType_Id", "dbo.tblResearchType");
            DropIndex("dbo.tblResearch", new[] { "ResearchStatuses_Id" });
            DropIndex("dbo.tblResearch", new[] { "ResearchType_Id" });
            AddColumn("dbo.tblResearch", "ResearchType_Id1", c => c.Int());
            AlterColumn("dbo.tblResearch", "ResearchStatuses_Id", c => c.Int());
            AlterColumn("dbo.tblResearch", "ResearchType_Id", c => c.Int());
            CreateIndex("dbo.tblResearch", "ResearchType_Id");
            CreateIndex("dbo.tblResearch", "ResearchStatuses_Id");
            CreateIndex("dbo.tblResearch", "ResearchType_Id1");
            AddForeignKey("dbo.tblResearch", "ResearchStatuses_Id", "dbo.tblResearchType", "Id");
            AddForeignKey("dbo.tblResearch", "ResearchType_Id1", "dbo.tblResearchType", "Id");
            AddForeignKey("dbo.tblResearch", "ResearchType_Id", "dbo.tblResearchType", "Id");
            DropTable("dbo.tblResearchStatus");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.tblResearchStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StatusName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("dbo.tblResearch", "ResearchType_Id", "dbo.tblResearchType");
            DropForeignKey("dbo.tblResearch", "ResearchType_Id1", "dbo.tblResearchType");
            DropForeignKey("dbo.tblResearch", "ResearchStatuses_Id", "dbo.tblResearchType");
            DropIndex("dbo.tblResearch", new[] { "ResearchType_Id1" });
            DropIndex("dbo.tblResearch", new[] { "ResearchStatuses_Id" });
            DropIndex("dbo.tblResearch", new[] { "ResearchType_Id" });
            AlterColumn("dbo.tblResearch", "ResearchType_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.tblResearch", "ResearchStatuses_Id", c => c.Int(nullable: false));
            DropColumn("dbo.tblResearch", "ResearchType_Id1");
            CreateIndex("dbo.tblResearch", "ResearchType_Id");
            CreateIndex("dbo.tblResearch", "ResearchStatuses_Id");
            AddForeignKey("dbo.tblResearch", "ResearchType_Id", "dbo.tblResearchType", "Id", cascadeDelete: true);
            AddForeignKey("dbo.tblResearch", "ResearchStatuses_Id", "dbo.tblResearchStatus", "Id", cascadeDelete: true);
        }
    }
}
