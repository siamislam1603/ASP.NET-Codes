namespace ViewModels.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenre : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Movies", "genreId", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "genreId" });
            DropPrimaryKey("dbo.Genres");
            AlterColumn("dbo.Movies", "genreId", c => c.Byte(nullable: true));
            AlterColumn("dbo.Genres", "id", c => c.Byte(nullable: false));
            AddPrimaryKey("dbo.Genres", "id");
            CreateIndex("dbo.Movies", "genreId");
            AddForeignKey("dbo.Movies", "genreId", "dbo.Genres", "id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "genreId", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "genreId" });
            DropPrimaryKey("dbo.Genres");
            AlterColumn("dbo.Genres", "id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Movies", "genreId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Genres", "id");
            CreateIndex("dbo.Movies", "genreId");
            AddForeignKey("dbo.Movies", "genreId", "dbo.Genres", "id", cascadeDelete: true);
        }
    }
}
