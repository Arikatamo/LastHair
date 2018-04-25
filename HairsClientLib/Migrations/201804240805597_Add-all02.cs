namespace HairsClientLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addall02 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.tblPatient", "ContactId", "dbo.tblContscts");
            DropIndex("dbo.tblPatient", new[] { "ContactId" });
            AddColumn("dbo.tblContscts", "Patient_Id", c => c.Int());
            CreateIndex("dbo.tblContscts", "Patient_Id");
            AddForeignKey("dbo.tblContscts", "Patient_Id", "dbo.tblPatient", "Id");
            DropColumn("dbo.tblPatient", "ContactId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tblPatient", "ContactId", c => c.Int(nullable: false));
            DropForeignKey("dbo.tblContscts", "Patient_Id", "dbo.tblPatient");
            DropIndex("dbo.tblContscts", new[] { "Patient_Id" });
            DropColumn("dbo.tblContscts", "Patient_Id");
            CreateIndex("dbo.tblPatient", "ContactId");
            AddForeignKey("dbo.tblPatient", "ContactId", "dbo.tblContscts", "Id", cascadeDelete: true);
        }
    }
}
