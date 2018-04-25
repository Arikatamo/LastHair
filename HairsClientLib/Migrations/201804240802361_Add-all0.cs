namespace HairsClientLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addall0 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.tblUser", "Visit_Id", "dbo.tblVisit");
            DropIndex("dbo.tblUser", new[] { "Visit_Id" });
            CreateTable(
                "dbo.VisitUsers",
                c => new
                    {
                        Visit_Id = c.Int(nullable: false),
                        User_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Visit_Id, t.User_Id })
                .ForeignKey("dbo.tblVisit", t => t.Visit_Id, cascadeDelete: true)
                .ForeignKey("dbo.tblUser", t => t.User_Id, cascadeDelete: true)
                .Index(t => t.Visit_Id)
                .Index(t => t.User_Id);
            
            DropColumn("dbo.tblUser", "Visit_Id");
            DropColumn("dbo.tblVisit", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tblVisit", "UserId", c => c.Int(nullable: false));
            AddColumn("dbo.tblUser", "Visit_Id", c => c.Int());
            DropForeignKey("dbo.VisitUsers", "User_Id", "dbo.tblUser");
            DropForeignKey("dbo.VisitUsers", "Visit_Id", "dbo.tblVisit");
            DropIndex("dbo.VisitUsers", new[] { "User_Id" });
            DropIndex("dbo.VisitUsers", new[] { "Visit_Id" });
            DropTable("dbo.VisitUsers");
            CreateIndex("dbo.tblUser", "Visit_Id");
            AddForeignKey("dbo.tblUser", "Visit_Id", "dbo.tblVisit", "Id");
        }
    }
}
