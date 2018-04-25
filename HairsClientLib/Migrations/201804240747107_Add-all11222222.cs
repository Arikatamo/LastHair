namespace HairsClientLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addall11222222 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.tblUser", "ContactId", "dbo.tblContscts");
            DropIndex("dbo.tblUser", new[] { "ContactId" });
            AddColumn("dbo.tblContscts", "User_Id", c => c.Int());
            CreateIndex("dbo.tblContscts", "User_Id");
            AddForeignKey("dbo.tblContscts", "User_Id", "dbo.tblUser", "Id");
            DropColumn("dbo.tblUser", "ContactId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tblUser", "ContactId", c => c.Int(nullable: false));
            DropForeignKey("dbo.tblContscts", "User_Id", "dbo.tblUser");
            DropIndex("dbo.tblContscts", new[] { "User_Id" });
            DropColumn("dbo.tblContscts", "User_Id");
            CreateIndex("dbo.tblUser", "ContactId");
            AddForeignKey("dbo.tblUser", "ContactId", "dbo.tblContscts", "Id", cascadeDelete: true);
        }
    }
}
