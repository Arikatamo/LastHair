namespace HairsClientLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addall2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.tblContscts", "GenderSId", "dbo.tblGender");
            DropForeignKey("dbo.tblPhotoses", "Patient_Id", "dbo.tblPatient");
            DropIndex("dbo.tblContscts", new[] { "GenderSId" });
            DropIndex("dbo.tblPhotoses", new[] { "Patient_Id" });
            RenameColumn(table: "dbo.tblContscts", name: "GenderSId", newName: "Gender_Id");
            AlterColumn("dbo.tblContscts", "Gender_Id", c => c.Int());
            AlterColumn("dbo.tblPhotoses", "Patient_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.tblContscts", "Gender_Id");
            CreateIndex("dbo.tblPhotoses", "Patient_Id");
            AddForeignKey("dbo.tblContscts", "Gender_Id", "dbo.tblGender", "Id");
            AddForeignKey("dbo.tblPhotoses", "Patient_Id", "dbo.tblPatient", "Id", cascadeDelete: true);
            DropColumn("dbo.tblPatient", "PhotosId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tblPatient", "PhotosId", c => c.Int(nullable: false));
            DropForeignKey("dbo.tblPhotoses", "Patient_Id", "dbo.tblPatient");
            DropForeignKey("dbo.tblContscts", "Gender_Id", "dbo.tblGender");
            DropIndex("dbo.tblPhotoses", new[] { "Patient_Id" });
            DropIndex("dbo.tblContscts", new[] { "Gender_Id" });
            AlterColumn("dbo.tblPhotoses", "Patient_Id", c => c.Int());
            AlterColumn("dbo.tblContscts", "Gender_Id", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.tblContscts", name: "Gender_Id", newName: "GenderSId");
            CreateIndex("dbo.tblPhotoses", "Patient_Id");
            CreateIndex("dbo.tblContscts", "GenderSId");
            AddForeignKey("dbo.tblPhotoses", "Patient_Id", "dbo.tblPatient", "Id");
            AddForeignKey("dbo.tblContscts", "GenderSId", "dbo.tblGender", "Id", cascadeDelete: true);
        }
    }
}
