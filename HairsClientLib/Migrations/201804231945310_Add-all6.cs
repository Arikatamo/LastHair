namespace HairsClientLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addall6 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.tblResearch", "ObjectiveId", "dbo.tblObjectives");
            DropIndex("dbo.tblResearch", new[] { "ObjectiveId" });
            RenameColumn(table: "dbo.tblResearch", name: "ObjectiveId", newName: "Lens_Id");
            AlterColumn("dbo.tblResearch", "Lens_Id", c => c.Int());
            CreateIndex("dbo.tblResearch", "Lens_Id");
            AddForeignKey("dbo.tblResearch", "Lens_Id", "dbo.tblObjectives", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblResearch", "Lens_Id", "dbo.tblObjectives");
            DropIndex("dbo.tblResearch", new[] { "Lens_Id" });
            AlterColumn("dbo.tblResearch", "Lens_Id", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.tblResearch", name: "Lens_Id", newName: "ObjectiveId");
            CreateIndex("dbo.tblResearch", "ObjectiveId");
            AddForeignKey("dbo.tblResearch", "ObjectiveId", "dbo.tblObjectives", "Id", cascadeDelete: true);
        }
    }
}
