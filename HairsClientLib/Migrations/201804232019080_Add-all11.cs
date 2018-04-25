namespace HairsClientLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addall11 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.tblUser", "AccesRightId", "dbo.tblAccesRight");
            DropIndex("dbo.tblUser", new[] { "AccesRightId" });
            RenameColumn(table: "dbo.tblUser", name: "AccesRightId", newName: "Access_Id");
            AlterColumn("dbo.tblUser", "Access_Id", c => c.Int());
            CreateIndex("dbo.tblUser", "Access_Id");
            AddForeignKey("dbo.tblUser", "Access_Id", "dbo.tblAccesRight", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblUser", "Access_Id", "dbo.tblAccesRight");
            DropIndex("dbo.tblUser", new[] { "Access_Id" });
            AlterColumn("dbo.tblUser", "Access_Id", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.tblUser", name: "Access_Id", newName: "AccesRightId");
            CreateIndex("dbo.tblUser", "AccesRightId");
            AddForeignKey("dbo.tblUser", "AccesRightId", "dbo.tblAccesRight", "Id", cascadeDelete: true);
        }
    }
}
