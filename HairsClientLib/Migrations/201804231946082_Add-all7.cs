namespace HairsClientLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addall7 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.tblUser", "LinseId", "dbo.tblObjectives");
            DropIndex("dbo.tblUser", new[] { "LinseId" });
            RenameColumn(table: "dbo.tblUser", name: "LinseId", newName: "Linse_Id");
            AlterColumn("dbo.tblUser", "Linse_Id", c => c.Int());
            CreateIndex("dbo.tblUser", "Linse_Id");
            AddForeignKey("dbo.tblUser", "Linse_Id", "dbo.tblObjectives", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblUser", "Linse_Id", "dbo.tblObjectives");
            DropIndex("dbo.tblUser", new[] { "Linse_Id" });
            AlterColumn("dbo.tblUser", "Linse_Id", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.tblUser", name: "Linse_Id", newName: "LinseId");
            CreateIndex("dbo.tblUser", "LinseId");
            AddForeignKey("dbo.tblUser", "LinseId", "dbo.tblObjectives", "Id", cascadeDelete: true);
        }
    }
}
