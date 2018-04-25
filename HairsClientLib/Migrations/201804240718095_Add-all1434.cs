namespace HairsClientLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addall1434 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.tblResearch", "PhotosId", "dbo.tblPhotoses");
            DropForeignKey("dbo.tblPhotoses", "Patient_Id", "dbo.tblPatient");
            DropIndex("dbo.tblResearch", new[] { "PhotosId" });
            DropIndex("dbo.tblPhotoses", new[] { "Patient_Id" });
            AddColumn("dbo.tblPhotoses", "Researches_Id", c => c.Int());
            AlterColumn("dbo.tblPhotoses", "Patient_Id", c => c.Int());
            CreateIndex("dbo.tblPhotoses", "Patient_Id");
            CreateIndex("dbo.tblPhotoses", "Researches_Id");
            AddForeignKey("dbo.tblPhotoses", "Researches_Id", "dbo.tblResearch", "Id");
            AddForeignKey("dbo.tblPhotoses", "Patient_Id", "dbo.tblPatient", "Id");
            DropColumn("dbo.tblResearch", "PhotosId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tblResearch", "PhotosId", c => c.Int(nullable: false));
            DropForeignKey("dbo.tblPhotoses", "Patient_Id", "dbo.tblPatient");
            DropForeignKey("dbo.tblPhotoses", "Researches_Id", "dbo.tblResearch");
            DropIndex("dbo.tblPhotoses", new[] { "Researches_Id" });
            DropIndex("dbo.tblPhotoses", new[] { "Patient_Id" });
            AlterColumn("dbo.tblPhotoses", "Patient_Id", c => c.Int(nullable: false));
            DropColumn("dbo.tblPhotoses", "Researches_Id");
            CreateIndex("dbo.tblPhotoses", "Patient_Id");
            CreateIndex("dbo.tblResearch", "PhotosId");
            AddForeignKey("dbo.tblPhotoses", "Patient_Id", "dbo.tblPatient", "Id", cascadeDelete: true);
            AddForeignKey("dbo.tblResearch", "PhotosId", "dbo.tblPhotoses", "Id", cascadeDelete: true);
        }
    }
}
