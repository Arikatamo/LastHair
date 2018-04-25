namespace HairsClientLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addall4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.tblResearch", "DiagnosId", "dbo.tblDiagnoses");
            DropForeignKey("dbo.tblReportfield", "FieldTypeId", "dbo.tblFieldType");
            DropForeignKey("dbo.tblReportfield", "FieldVariantId", "dbo.tblFieldVariants");
            DropIndex("dbo.tblReportfield", new[] { "FieldTypeId" });
            DropIndex("dbo.tblReportfield", new[] { "FieldVariantId" });
            DropIndex("dbo.tblResearch", new[] { "DiagnosId" });
            RenameColumn(table: "dbo.tblResearch", name: "DiagnosId", newName: "Diagnos_Id");
            RenameColumn(table: "dbo.tblReportfield", name: "FieldTypeId", newName: "FieldType_Id");
            RenameColumn(table: "dbo.tblReportfield", name: "FieldVariantId", newName: "FieldVariant_Id");
            AddColumn("dbo.tblResearch", "Diagnoses_Id", c => c.Int());
            AlterColumn("dbo.tblReportfield", "FieldType_Id", c => c.Int());
            AlterColumn("dbo.tblReportfield", "FieldVariant_Id", c => c.Int());
            AlterColumn("dbo.tblResearch", "Diagnos_Id", c => c.Int());
            CreateIndex("dbo.tblResearch", "Diagnos_Id");
            CreateIndex("dbo.tblResearch", "Diagnoses_Id");
            CreateIndex("dbo.tblReportfield", "FieldType_Id");
            CreateIndex("dbo.tblReportfield", "FieldVariant_Id");
            AddForeignKey("dbo.tblResearch", "Diagnoses_Id", "dbo.tblDiagnoses", "Id");
            AddForeignKey("dbo.tblResearch", "Diagnos_Id", "dbo.tblConfigHair", "Id");
            AddForeignKey("dbo.tblReportfield", "FieldType_Id", "dbo.tblFieldType", "Id");
            AddForeignKey("dbo.tblReportfield", "FieldVariant_Id", "dbo.tblFieldVariants", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblReportfield", "FieldVariant_Id", "dbo.tblFieldVariants");
            DropForeignKey("dbo.tblReportfield", "FieldType_Id", "dbo.tblFieldType");
            DropForeignKey("dbo.tblResearch", "Diagnos_Id", "dbo.tblConfigHair");
            DropForeignKey("dbo.tblResearch", "Diagnoses_Id", "dbo.tblDiagnoses");
            DropIndex("dbo.tblReportfield", new[] { "FieldVariant_Id" });
            DropIndex("dbo.tblReportfield", new[] { "FieldType_Id" });
            DropIndex("dbo.tblResearch", new[] { "Diagnoses_Id" });
            DropIndex("dbo.tblResearch", new[] { "Diagnos_Id" });
            AlterColumn("dbo.tblResearch", "Diagnos_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.tblReportfield", "FieldVariant_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.tblReportfield", "FieldType_Id", c => c.Int(nullable: false));
            DropColumn("dbo.tblResearch", "Diagnoses_Id");
            RenameColumn(table: "dbo.tblReportfield", name: "FieldVariant_Id", newName: "FieldVariantId");
            RenameColumn(table: "dbo.tblReportfield", name: "FieldType_Id", newName: "FieldTypeId");
            RenameColumn(table: "dbo.tblResearch", name: "Diagnos_Id", newName: "DiagnosId");
            CreateIndex("dbo.tblResearch", "DiagnosId");
            CreateIndex("dbo.tblReportfield", "FieldVariantId");
            CreateIndex("dbo.tblReportfield", "FieldTypeId");
            AddForeignKey("dbo.tblReportfield", "FieldVariantId", "dbo.tblFieldVariants", "Id", cascadeDelete: true);
            AddForeignKey("dbo.tblReportfield", "FieldTypeId", "dbo.tblFieldType", "Id", cascadeDelete: true);
            AddForeignKey("dbo.tblResearch", "DiagnosId", "dbo.tblDiagnoses", "Id", cascadeDelete: true);
        }
    }
}
