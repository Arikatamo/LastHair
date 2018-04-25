namespace HairsClientLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addall145 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.tblResearch", "Lens_Id", "dbo.tblObjectives");
            DropForeignKey("dbo.tblResearch", "Diagnos_Id", "dbo.tblConfigHair");
            DropForeignKey("dbo.tblResearch", "Hair_Id", "dbo.tblHair");
            DropForeignKey("dbo.tblResearch", "Diagnoses_Id", "dbo.tblDiagnoses");
            DropIndex("dbo.tblResearch", new[] { "Diagnos_Id" });
            DropIndex("dbo.tblResearch", new[] { "Hair_Id" });
            DropIndex("dbo.tblResearch", new[] { "Lens_Id" });
            DropIndex("dbo.tblResearch", new[] { "Diagnoses_Id" });
            DropColumn("dbo.tblResearch", "Diagnos_Id");
            RenameColumn(table: "dbo.tblConfigHair", name: "ConfHaitSizeId", newName: "ConfHairSize_Id");
            RenameColumn(table: "dbo.tblConfigHair", name: "ConfStatNormalId", newName: "ConfStatNormal_Id");
            RenameColumn(table: "dbo.tblResearch", name: "ConfigId", newName: "Config_Id");
            RenameColumn(table: "dbo.tblResearch", name: "Diagnoses_Id", newName: "Diagnos_Id");
            RenameIndex(table: "dbo.tblConfigHair", name: "IX_ConfHaitSizeId", newName: "IX_ConfHairSize_Id");
            RenameIndex(table: "dbo.tblConfigHair", name: "IX_ConfStatNormalId", newName: "IX_ConfStatNormal_Id");
            RenameIndex(table: "dbo.tblResearch", name: "IX_ConfigId", newName: "IX_Config_Id");
            AlterColumn("dbo.tblResearch", "Diagnos_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.tblResearch", "Hair_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.tblResearch", "Lens_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.tblResearch", "Diagnos_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.tblResearch", "Diagnos_Id");
            CreateIndex("dbo.tblResearch", "Hair_Id");
            CreateIndex("dbo.tblResearch", "Lens_Id");
            AddForeignKey("dbo.tblResearch", "Lens_Id", "dbo.tblObjectives", "Id", cascadeDelete: true);
            AddForeignKey("dbo.tblResearch", "Diagnos_Id", "dbo.tblDiagnoses", "Id", cascadeDelete: true);
            AddForeignKey("dbo.tblResearch", "Hair_Id", "dbo.tblHair", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblResearch", "Hair_Id", "dbo.tblHair");
            DropForeignKey("dbo.tblResearch", "Diagnos_Id", "dbo.tblDiagnoses");
            DropForeignKey("dbo.tblResearch", "Lens_Id", "dbo.tblObjectives");
            DropIndex("dbo.tblResearch", new[] { "Lens_Id" });
            DropIndex("dbo.tblResearch", new[] { "Hair_Id" });
            DropIndex("dbo.tblResearch", new[] { "Diagnos_Id" });
            AlterColumn("dbo.tblResearch", "Diagnos_Id", c => c.Int());
            AlterColumn("dbo.tblResearch", "Lens_Id", c => c.Int());
            AlterColumn("dbo.tblResearch", "Hair_Id", c => c.Int());
            AlterColumn("dbo.tblResearch", "Diagnos_Id", c => c.Int());
            RenameIndex(table: "dbo.tblResearch", name: "IX_Config_Id", newName: "IX_ConfigId");
            RenameIndex(table: "dbo.tblConfigHair", name: "IX_ConfStatNormal_Id", newName: "IX_ConfStatNormalId");
            RenameIndex(table: "dbo.tblConfigHair", name: "IX_ConfHairSize_Id", newName: "IX_ConfHaitSizeId");
            RenameColumn(table: "dbo.tblResearch", name: "Diagnos_Id", newName: "Diagnoses_Id");
            RenameColumn(table: "dbo.tblResearch", name: "Config_Id", newName: "ConfigId");
            RenameColumn(table: "dbo.tblConfigHair", name: "ConfStatNormal_Id", newName: "ConfStatNormalId");
            RenameColumn(table: "dbo.tblConfigHair", name: "ConfHairSize_Id", newName: "ConfHaitSizeId");
            AddColumn("dbo.tblResearch", "Diagnos_Id", c => c.Int());
            CreateIndex("dbo.tblResearch", "Diagnoses_Id");
            CreateIndex("dbo.tblResearch", "Lens_Id");
            CreateIndex("dbo.tblResearch", "Hair_Id");
            CreateIndex("dbo.tblResearch", "Diagnos_Id");
            AddForeignKey("dbo.tblResearch", "Diagnoses_Id", "dbo.tblDiagnoses", "Id");
            AddForeignKey("dbo.tblResearch", "Hair_Id", "dbo.tblHair", "Id");
            AddForeignKey("dbo.tblResearch", "Diagnos_Id", "dbo.tblConfigHair", "Id");
            AddForeignKey("dbo.tblResearch", "Lens_Id", "dbo.tblObjectives", "Id");
        }
    }
}
