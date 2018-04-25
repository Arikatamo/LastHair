namespace HairsClientLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addall3 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.tblCommentaryToVisit", name: "CommentaryTypeId", newName: "CommentaryType_Id");
            RenameIndex(table: "dbo.tblCommentaryToVisit", name: "IX_CommentaryTypeId", newName: "IX_CommentaryType_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.tblCommentaryToVisit", name: "IX_CommentaryType_Id", newName: "IX_CommentaryTypeId");
            RenameColumn(table: "dbo.tblCommentaryToVisit", name: "CommentaryType_Id", newName: "CommentaryTypeId");
        }
    }
}
