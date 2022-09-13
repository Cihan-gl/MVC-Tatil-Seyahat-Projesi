namespace TravelTripProje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bir : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Yorumlars", "Blog_BlogID", "dbo.Blogs");
            DropIndex("dbo.Yorumlars", new[] { "Blog_BlogID" });
            RenameColumn(table: "dbo.Yorumlars", name: "Blog_BlogID", newName: "BlogID");
            AlterColumn("dbo.Yorumlars", "BlogID", c => c.Int(nullable: false));
            CreateIndex("dbo.Yorumlars", "BlogID");
            AddForeignKey("dbo.Yorumlars", "BlogID", "dbo.Blogs", "BlogID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Yorumlars", "BlogID", "dbo.Blogs");
            DropIndex("dbo.Yorumlars", new[] { "BlogID" });
            AlterColumn("dbo.Yorumlars", "BlogID", c => c.Int());
            RenameColumn(table: "dbo.Yorumlars", name: "BlogID", newName: "Blog_BlogID");
            CreateIndex("dbo.Yorumlars", "Blog_BlogID");
            AddForeignKey("dbo.Yorumlars", "Blog_BlogID", "dbo.Blogs", "BlogID");
        }
    }
}
