namespace HairsClientLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update232 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblResearchStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StatusName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.tblResearch", "ResearStatus_Id", c => c.Int());
            CreateIndex("dbo.tblResearch", "ResearStatus_Id");
            AddForeignKey("dbo.tblResearch", "ResearStatus_Id", "dbo.tblResearchStatus", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblResearch", "ResearStatus_Id", "dbo.tblResearchStatus");
            DropIndex("dbo.tblResearch", new[] { "ResearStatus_Id" });
            DropColumn("dbo.tblResearch", "ResearStatus_Id");
            DropTable("dbo.tblResearchStatus");
        }
    }
}
