namespace HairsClientLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addall112222 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.tblUser", "ResearchId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tblUser", "ResearchId", c => c.Int(nullable: false));
        }
    }
}
