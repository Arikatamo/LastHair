namespace HairsClientLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addall : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblAccesRight",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AccessName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tblCommentaryToVisit",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CommentaryTypeId = c.Int(nullable: false),
                        Commentary = c.String(maxLength: 2000),
                        Visit_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tblCommentaryType", t => t.CommentaryTypeId, cascadeDelete: true)
                .ForeignKey("dbo.tblVisit", t => t.Visit_Id)
                .Index(t => t.CommentaryTypeId)
                .Index(t => t.Visit_Id);
            
            CreateTable(
                "dbo.tblCommentaryType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ToPatient = c.String(),
                        ToAdministrator = c.String(),
                        DoctorToPatient = c.String(),
                        AdministratorToHimselt = c.String(),
                        DoctorToHimSelf = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tblConfigHairSize",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TelogenHairLong = c.Short(nullable: false),
                        Diametr_Velus_Terminale = c.Short(nullable: false),
                        Diametr_Terminale_S_M = c.Short(nullable: false),
                        Diametr_Terminale_M_B = c.Short(nullable: false),
                        Radius_Folikular_Unit = c.Short(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tblConfigHair",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ConfHaitSizeId = c.Int(nullable: false),
                        ConfStatNormalId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tblConfigHairSize", t => t.ConfHaitSizeId, cascadeDelete: true)
                .ForeignKey("dbo.tblConfigStaticNormales", t => t.ConfStatNormalId, cascadeDelete: true)
                .Index(t => t.ConfHaitSizeId)
                .Index(t => t.ConfStatNormalId);
            
            CreateTable(
                "dbo.tblConfigStaticNormales",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AnagenAll = c.Int(nullable: false),
                        TelogenAll = c.Int(nullable: false),
                        AnagenTerm = c.Int(nullable: false),
                        TelogenTerm = c.Int(nullable: false),
                        AnagenVelus = c.Int(nullable: false),
                        TelogenVelus = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tblContscts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        SecondName = c.String(nullable: false, maxLength: 100),
                        FatherName = c.String(nullable: false, maxLength: 100),
                        GenderSId = c.Int(nullable: false),
                        DateOfBirth = c.DateTime(nullable: false),
                        Phone = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 100),
                        Adress = c.String(nullable: false, maxLength: 300),
                        Post = c.String(nullable: false, maxLength: 100),
                        Speciality = c.String(nullable: false, maxLength: 100),
                        Education = c.String(nullable: false, maxLength: 100),
                        Commentary = c.String(nullable: false, maxLength: 1000),
                        Grade = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tblGender", t => t.GenderSId, cascadeDelete: true)
                .Index(t => t.GenderSId);
            
            CreateTable(
                "dbo.tblGender",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Gender = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tblDiagnoses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Diagnos = c.String(nullable: false, maxLength: 2000),
                        BeginDate = c.DateTime(nullable: false),
                        DateOfLastConfirm = c.DateTime(nullable: false),
                        Commentary = c.String(nullable: false, maxLength: 1000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tblFieldType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        ReportTemplate_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tblReportTemplate", t => t.ReportTemplate_Id)
                .Index(t => t.ReportTemplate_Id);
            
            CreateTable(
                "dbo.tblFieldVariants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameAndina = c.String(nullable: false, maxLength: 100),
                        Selected = c.Boolean(nullable: false),
                        Text = c.String(nullable: false, maxLength: 2000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tblHair",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Width = c.Int(nullable: false),
                        x1 = c.Int(nullable: false),
                        y1 = c.Int(nullable: false),
                        x2 = c.Int(nullable: false),
                        y2 = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tblImageLogo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Selected = c.Boolean(nullable: false),
                        Data = c.Binary(nullable: false),
                        ReportTemplate_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tblReportTemplate", t => t.ReportTemplate_Id)
                .Index(t => t.ReportTemplate_Id);
            
            CreateTable(
                "dbo.tblObjectives",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameObjectiv = c.String(nullable: false, maxLength: 50),
                        Scale = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tblPatient",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ContactId = c.Int(nullable: false),
                        DateCreate = c.DateTime(nullable: false),
                        Comment = c.String(nullable: false, maxLength: 2000),
                        PhotosId = c.Int(nullable: false),
                        DateNextVisit = c.DateTime(nullable: false),
                        TimeNextVisit = c.DateTime(nullable: false),
                        Status_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tblContscts", t => t.ContactId, cascadeDelete: true)
                .ForeignKey("dbo.tblStatusesForPatient", t => t.Status_Id, cascadeDelete: true)
                .Index(t => t.ContactId)
                .Index(t => t.Status_Id);
            
            CreateTable(
                "dbo.tblPhotoses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateOfCreate = c.DateTime(nullable: false),
                        Name = c.String(nullable: false, maxLength: 100),
                        Photo = c.Binary(nullable: false),
                        Patient_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tblPatient", t => t.Patient_Id)
                .Index(t => t.Patient_Id);
            
            CreateTable(
                "dbo.tblStatusesForPatient",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Status = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tblReportfield",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameDiagnos = c.String(nullable: false, maxLength: 100),
                        FieldTypeId = c.Int(nullable: false),
                        FieldVariantId = c.Int(nullable: false),
                        ReportTemplate_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tblFieldType", t => t.FieldTypeId, cascadeDelete: true)
                .ForeignKey("dbo.tblFieldVariants", t => t.FieldVariantId, cascadeDelete: true)
                .ForeignKey("dbo.tblReportTemplate", t => t.ReportTemplate_Id)
                .Index(t => t.FieldTypeId)
                .Index(t => t.FieldVariantId)
                .Index(t => t.ReportTemplate_Id);
            
            CreateTable(
                "dbo.tblReportTemplate",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ImgID = c.Int(nullable: false),
                        FieldTypeId = c.Int(nullable: false),
                        ReportFieldId = c.Int(nullable: false),
                        Research_Id = c.Int(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tblResearch", t => t.Research_Id)
                .ForeignKey("dbo.tblUser", t => t.User_Id)
                .Index(t => t.Research_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.tblResearch",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ResearchTypeId = c.Int(nullable: false),
                        ResearchStatusId = c.Int(nullable: false),
                        Thunmbnail = c.Binary(nullable: false),
                        PhotosId = c.Int(nullable: false),
                        HairsId = c.Int(nullable: false),
                        ResearchArea = c.Int(nullable: false),
                        Commentary = c.String(nullable: false, maxLength: 2000),
                        TimeResearch = c.DateTime(nullable: false),
                        DiagnosId = c.Int(nullable: false),
                        Treatment = c.String(nullable: false),
                        ConfigId = c.Int(nullable: false),
                        ObjectiveId = c.Int(nullable: false),
                        User_Id = c.Int(),
                        Visit_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tblConfigHair", t => t.ConfigId, cascadeDelete: true)
                .ForeignKey("dbo.tblDiagnoses", t => t.DiagnosId, cascadeDelete: true)
                .ForeignKey("dbo.tblHair", t => t.HairsId, cascadeDelete: true)
                .ForeignKey("dbo.tblObjectives", t => t.ObjectiveId, cascadeDelete: true)
                .ForeignKey("dbo.tblPhotoses", t => t.PhotosId, cascadeDelete: true)
                .ForeignKey("dbo.tblResearchStatus", t => t.ResearchStatusId, cascadeDelete: true)
                .ForeignKey("dbo.tblResearchType", t => t.ResearchTypeId, cascadeDelete: true)
                .ForeignKey("dbo.tblUser", t => t.User_Id)
                .ForeignKey("dbo.tblVisit", t => t.Visit_Id)
                .Index(t => t.ResearchTypeId)
                .Index(t => t.ResearchStatusId)
                .Index(t => t.PhotosId)
                .Index(t => t.HairsId)
                .Index(t => t.DiagnosId)
                .Index(t => t.ConfigId)
                .Index(t => t.ObjectiveId)
                .Index(t => t.User_Id)
                .Index(t => t.Visit_Id);
            
            CreateTable(
                "dbo.tblResearchStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StatusName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tblResearchType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tblUser",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(nullable: false, maxLength: 50),
                        Password = c.Binary(nullable: false, maxLength: 256),
                        LinseId = c.Int(nullable: false),
                        ResearchId = c.Int(nullable: false),
                        ConfigsId = c.Int(nullable: false),
                        ContactId = c.Int(nullable: false),
                        AccesRightId = c.Int(nullable: false),
                        ReporsId = c.Int(nullable: false),
                        Visit_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tblAccesRight", t => t.AccesRightId, cascadeDelete: true)
                .ForeignKey("dbo.tblConfigHair", t => t.ConfigsId, cascadeDelete: true)
                .ForeignKey("dbo.tblContscts", t => t.ContactId, cascadeDelete: true)
                .ForeignKey("dbo.tblObjectives", t => t.LinseId, cascadeDelete: true)
                .ForeignKey("dbo.tblVisit", t => t.Visit_Id)
                .Index(t => t.LinseId)
                .Index(t => t.ConfigsId)
                .Index(t => t.ContactId)
                .Index(t => t.AccesRightId)
                .Index(t => t.Visit_Id);
            
            CreateTable(
                "dbo.tblVisit",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        PatientId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Time = c.DateTime(nullable: false),
                        CommentaryId = c.Int(nullable: false),
                        ResearchId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tblPatient", t => t.PatientId, cascadeDelete: true)
                .Index(t => t.PatientId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblUser", "Visit_Id", "dbo.tblVisit");
            DropForeignKey("dbo.tblResearch", "Visit_Id", "dbo.tblVisit");
            DropForeignKey("dbo.tblVisit", "PatientId", "dbo.tblPatient");
            DropForeignKey("dbo.tblCommentaryToVisit", "Visit_Id", "dbo.tblVisit");
            DropForeignKey("dbo.tblResearch", "User_Id", "dbo.tblUser");
            DropForeignKey("dbo.tblReportTemplate", "User_Id", "dbo.tblUser");
            DropForeignKey("dbo.tblUser", "LinseId", "dbo.tblObjectives");
            DropForeignKey("dbo.tblUser", "ContactId", "dbo.tblContscts");
            DropForeignKey("dbo.tblUser", "ConfigsId", "dbo.tblConfigHair");
            DropForeignKey("dbo.tblUser", "AccesRightId", "dbo.tblAccesRight");
            DropForeignKey("dbo.tblResearch", "ResearchTypeId", "dbo.tblResearchType");
            DropForeignKey("dbo.tblResearch", "ResearchStatusId", "dbo.tblResearchStatus");
            DropForeignKey("dbo.tblReportTemplate", "Research_Id", "dbo.tblResearch");
            DropForeignKey("dbo.tblResearch", "PhotosId", "dbo.tblPhotoses");
            DropForeignKey("dbo.tblResearch", "ObjectiveId", "dbo.tblObjectives");
            DropForeignKey("dbo.tblResearch", "HairsId", "dbo.tblHair");
            DropForeignKey("dbo.tblResearch", "DiagnosId", "dbo.tblDiagnoses");
            DropForeignKey("dbo.tblResearch", "ConfigId", "dbo.tblConfigHair");
            DropForeignKey("dbo.tblReportfield", "ReportTemplate_Id", "dbo.tblReportTemplate");
            DropForeignKey("dbo.tblImageLogo", "ReportTemplate_Id", "dbo.tblReportTemplate");
            DropForeignKey("dbo.tblFieldType", "ReportTemplate_Id", "dbo.tblReportTemplate");
            DropForeignKey("dbo.tblReportfield", "FieldVariantId", "dbo.tblFieldVariants");
            DropForeignKey("dbo.tblReportfield", "FieldTypeId", "dbo.tblFieldType");
            DropForeignKey("dbo.tblPatient", "Status_Id", "dbo.tblStatusesForPatient");
            DropForeignKey("dbo.tblPhotoses", "Patient_Id", "dbo.tblPatient");
            DropForeignKey("dbo.tblPatient", "ContactId", "dbo.tblContscts");
            DropForeignKey("dbo.tblContscts", "GenderSId", "dbo.tblGender");
            DropForeignKey("dbo.tblConfigHair", "ConfStatNormalId", "dbo.tblConfigStaticNormales");
            DropForeignKey("dbo.tblConfigHair", "ConfHaitSizeId", "dbo.tblConfigHairSize");
            DropForeignKey("dbo.tblCommentaryToVisit", "CommentaryTypeId", "dbo.tblCommentaryType");
            DropIndex("dbo.tblVisit", new[] { "PatientId" });
            DropIndex("dbo.tblUser", new[] { "Visit_Id" });
            DropIndex("dbo.tblUser", new[] { "AccesRightId" });
            DropIndex("dbo.tblUser", new[] { "ContactId" });
            DropIndex("dbo.tblUser", new[] { "ConfigsId" });
            DropIndex("dbo.tblUser", new[] { "LinseId" });
            DropIndex("dbo.tblResearch", new[] { "Visit_Id" });
            DropIndex("dbo.tblResearch", new[] { "User_Id" });
            DropIndex("dbo.tblResearch", new[] { "ObjectiveId" });
            DropIndex("dbo.tblResearch", new[] { "ConfigId" });
            DropIndex("dbo.tblResearch", new[] { "DiagnosId" });
            DropIndex("dbo.tblResearch", new[] { "HairsId" });
            DropIndex("dbo.tblResearch", new[] { "PhotosId" });
            DropIndex("dbo.tblResearch", new[] { "ResearchStatusId" });
            DropIndex("dbo.tblResearch", new[] { "ResearchTypeId" });
            DropIndex("dbo.tblReportTemplate", new[] { "User_Id" });
            DropIndex("dbo.tblReportTemplate", new[] { "Research_Id" });
            DropIndex("dbo.tblReportfield", new[] { "ReportTemplate_Id" });
            DropIndex("dbo.tblReportfield", new[] { "FieldVariantId" });
            DropIndex("dbo.tblReportfield", new[] { "FieldTypeId" });
            DropIndex("dbo.tblPhotoses", new[] { "Patient_Id" });
            DropIndex("dbo.tblPatient", new[] { "Status_Id" });
            DropIndex("dbo.tblPatient", new[] { "ContactId" });
            DropIndex("dbo.tblImageLogo", new[] { "ReportTemplate_Id" });
            DropIndex("dbo.tblFieldType", new[] { "ReportTemplate_Id" });
            DropIndex("dbo.tblContscts", new[] { "GenderSId" });
            DropIndex("dbo.tblConfigHair", new[] { "ConfStatNormalId" });
            DropIndex("dbo.tblConfigHair", new[] { "ConfHaitSizeId" });
            DropIndex("dbo.tblCommentaryToVisit", new[] { "Visit_Id" });
            DropIndex("dbo.tblCommentaryToVisit", new[] { "CommentaryTypeId" });
            DropTable("dbo.tblVisit");
            DropTable("dbo.tblUser");
            DropTable("dbo.tblResearchType");
            DropTable("dbo.tblResearchStatus");
            DropTable("dbo.tblResearch");
            DropTable("dbo.tblReportTemplate");
            DropTable("dbo.tblReportfield");
            DropTable("dbo.tblStatusesForPatient");
            DropTable("dbo.tblPhotoses");
            DropTable("dbo.tblPatient");
            DropTable("dbo.tblObjectives");
            DropTable("dbo.tblImageLogo");
            DropTable("dbo.tblHair");
            DropTable("dbo.tblFieldVariants");
            DropTable("dbo.tblFieldType");
            DropTable("dbo.tblDiagnoses");
            DropTable("dbo.tblGender");
            DropTable("dbo.tblContscts");
            DropTable("dbo.tblConfigStaticNormales");
            DropTable("dbo.tblConfigHair");
            DropTable("dbo.tblConfigHairSize");
            DropTable("dbo.tblCommentaryType");
            DropTable("dbo.tblCommentaryToVisit");
            DropTable("dbo.tblAccesRight");
        }
    }
}
