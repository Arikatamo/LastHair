namespace HairsClientLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addall5 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.tblResearch", "HairsId", "dbo.tblHair");
            DropIndex("dbo.tblResearch", new[] { "HairsId" });
            RenameColumn(table: "dbo.tblResearch", name: "HairsId", newName: "Hair_Id");
            AlterColumn("dbo.tblResearch", "Hair_Id", c => c.Int());
            CreateIndex("dbo.tblResearch", "Hair_Id");
            AddForeignKey("dbo.tblResearch", "Hair_Id", "dbo.tblHair", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblResearch", "Hair_Id", "dbo.tblHair");
            DropIndex("dbo.tblResearch", new[] { "Hair_Id" });
            AlterColumn("dbo.tblResearch", "Hair_Id", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.tblResearch", name: "Hair_Id", newName: "HairsId");
            CreateIndex("dbo.tblResearch", "HairsId");
            AddForeignKey("dbo.tblResearch", "HairsId", "dbo.tblHair", "Id", cascadeDelete: true);
        }
    }
}
