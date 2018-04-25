namespace HairsClientLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addall1122 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.tblImageLogo", "RepTemplate_Id", "dbo.tblReportTemplate");
            DropForeignKey("dbo.tblReportTemplate", "Research_Id", "dbo.tblResearch");
            DropForeignKey("dbo.tblReportfield", "FieldType_Id", "dbo.tblFieldType");
            DropForeignKey("dbo.tblReportfield", "FieldVariant_Id", "dbo.tblFieldVariants");
            DropForeignKey("dbo.tblCommentaryToVisit", "Visit_Id", "dbo.tblVisit");
            DropForeignKey("dbo.tblVisit", "PatientId", "dbo.tblPatient");
            DropForeignKey("dbo.tblResearch", "Visit_Id", "dbo.tblVisit");
            DropIndex("dbo.tblResearch", new[] { "Visit_Id" });
            DropIndex("dbo.tblReportTemplate", new[] { "Research_Id" });
            DropIndex("dbo.tblReportfield", new[] { "FieldType_Id" });
            DropIndex("dbo.tblReportfield", new[] { "FieldVariant_Id" });
            DropIndex("dbo.tblImageLogo", new[] { "RepTemplate_Id" });
            DropIndex("dbo.tblCommentaryToVisit", new[] { "Visit_Id" });
            DropIndex("dbo.tblVisit", new[] { "PatientId" });
            RenameColumn(table: "dbo.tblVisit", name: "PatientId", newName: "Patients_Id");
            AlterColumn("dbo.tblResearch", "Visit_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.tblReportTemplate", "Research_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.tblReportfield", "FieldType_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.tblReportfield", "FieldVariant_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.tblImageLogo", "RepTemplate_Id", c => c.Int());
            AlterColumn("dbo.tblCommentaryToVisit", "Visit_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.tblVisit", "Patients_Id", c => c.Int());
            CreateIndex("dbo.tblResearch", "Visit_Id");
            CreateIndex("dbo.tblVisit", "Patients_Id");
            CreateIndex("dbo.tblCommentaryToVisit", "Visit_Id");
            CreateIndex("dbo.tblReportTemplate", "Research_Id");
            CreateIndex("dbo.tblReportfield", "FieldType_Id");
            CreateIndex("dbo.tblReportfield", "FieldVariant_Id");
            CreateIndex("dbo.tblImageLogo", "RepTemplate_Id");
            AddForeignKey("dbo.tblImageLogo", "RepTemplate_Id", "dbo.tblReportTemplate", "Id");
            AddForeignKey("dbo.tblReportTemplate", "Research_Id", "dbo.tblResearch", "Id", cascadeDelete: true);
            AddForeignKey("dbo.tblReportfield", "FieldType_Id", "dbo.tblFieldType", "Id", cascadeDelete: true);
            AddForeignKey("dbo.tblReportfield", "FieldVariant_Id", "dbo.tblFieldVariants", "Id", cascadeDelete: true);
            AddForeignKey("dbo.tblCommentaryToVisit", "Visit_Id", "dbo.tblVisit", "Id", cascadeDelete: true);
            AddForeignKey("dbo.tblVisit", "Patients_Id", "dbo.tblPatient", "Id");
            AddForeignKey("dbo.tblResearch", "Visit_Id", "dbo.tblVisit", "Id", cascadeDelete: true);
            DropColumn("dbo.tblVisit", "CommentaryId");
            DropColumn("dbo.tblVisit", "ResearchId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tblVisit", "ResearchId", c => c.Int(nullable: false));
            AddColumn("dbo.tblVisit", "CommentaryId", c => c.Int(nullable: false));
            DropForeignKey("dbo.tblResearch", "Visit_Id", "dbo.tblVisit");
            DropForeignKey("dbo.tblVisit", "Patients_Id", "dbo.tblPatient");
            DropForeignKey("dbo.tblCommentaryToVisit", "Visit_Id", "dbo.tblVisit");
            DropForeignKey("dbo.tblReportfield", "FieldVariant_Id", "dbo.tblFieldVariants");
            DropForeignKey("dbo.tblReportfield", "FieldType_Id", "dbo.tblFieldType");
            DropForeignKey("dbo.tblReportTemplate", "Research_Id", "dbo.tblResearch");
            DropForeignKey("dbo.tblImageLogo", "RepTemplate_Id", "dbo.tblReportTemplate");
            DropIndex("dbo.tblImageLogo", new[] { "RepTemplate_Id" });
            DropIndex("dbo.tblReportfield", new[] { "FieldVariant_Id" });
            DropIndex("dbo.tblReportfield", new[] { "FieldType_Id" });
            DropIndex("dbo.tblReportTemplate", new[] { "Research_Id" });
            DropIndex("dbo.tblCommentaryToVisit", new[] { "Visit_Id" });
            DropIndex("dbo.tblVisit", new[] { "Patients_Id" });
            DropIndex("dbo.tblResearch", new[] { "Visit_Id" });
            AlterColumn("dbo.tblVisit", "Patients_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.tblCommentaryToVisit", "Visit_Id", c => c.Int());
            AlterColumn("dbo.tblImageLogo", "RepTemplate_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.tblReportfield", "FieldVariant_Id", c => c.Int());
            AlterColumn("dbo.tblReportfield", "FieldType_Id", c => c.Int());
            AlterColumn("dbo.tblReportTemplate", "Research_Id", c => c.Int());
            AlterColumn("dbo.tblResearch", "Visit_Id", c => c.Int());
            RenameColumn(table: "dbo.tblVisit", name: "Patients_Id", newName: "PatientId");
            CreateIndex("dbo.tblVisit", "PatientId");
            CreateIndex("dbo.tblCommentaryToVisit", "Visit_Id");
            CreateIndex("dbo.tblImageLogo", "RepTemplate_Id");
            CreateIndex("dbo.tblReportfield", "FieldVariant_Id");
            CreateIndex("dbo.tblReportfield", "FieldType_Id");
            CreateIndex("dbo.tblReportTemplate", "Research_Id");
            CreateIndex("dbo.tblResearch", "Visit_Id");
            AddForeignKey("dbo.tblResearch", "Visit_Id", "dbo.tblVisit", "Id");
            AddForeignKey("dbo.tblVisit", "PatientId", "dbo.tblPatient", "Id", cascadeDelete: true);
            AddForeignKey("dbo.tblCommentaryToVisit", "Visit_Id", "dbo.tblVisit", "Id");
            AddForeignKey("dbo.tblReportfield", "FieldVariant_Id", "dbo.tblFieldVariants", "Id");
            AddForeignKey("dbo.tblReportfield", "FieldType_Id", "dbo.tblFieldType", "Id");
            AddForeignKey("dbo.tblReportTemplate", "Research_Id", "dbo.tblResearch", "Id");
            AddForeignKey("dbo.tblImageLogo", "RepTemplate_Id", "dbo.tblReportTemplate", "Id", cascadeDelete: true);
        }
    }
}
