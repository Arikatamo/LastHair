namespace HairsClientLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addall1122222 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.tblUser", "ConfigsId", "dbo.tblConfigHair");
            DropIndex("dbo.tblUser", new[] { "ConfigsId" });
            RenameColumn(table: "dbo.tblUser", name: "ConfigsId", newName: "Config_Id");
            AlterColumn("dbo.tblUser", "Config_Id", c => c.Int());
            CreateIndex("dbo.tblUser", "Config_Id");
            AddForeignKey("dbo.tblUser", "Config_Id", "dbo.tblConfigHair", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblUser", "Config_Id", "dbo.tblConfigHair");
            DropIndex("dbo.tblUser", new[] { "Config_Id" });
            AlterColumn("dbo.tblUser", "Config_Id", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.tblUser", name: "Config_Id", newName: "ConfigsId");
            CreateIndex("dbo.tblUser", "ConfigsId");
            AddForeignKey("dbo.tblUser", "ConfigsId", "dbo.tblConfigHair", "Id", cascadeDelete: true);
        }
    }
}
