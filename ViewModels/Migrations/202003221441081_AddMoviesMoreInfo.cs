namespace ViewModels.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMoviesMoreInfo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "ReleaseDate", c => c.DateTime(nullable: true, defaultValue: null));
            AddColumn("dbo.Movies", "AddedDate", c => c.DateTime(nullable: true, defaultValue: null));
            AddColumn("dbo.Movies", "NoInStock", c => c.Int(nullable: true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "ReleaseDate");
            DropColumn("dbo.Movies", "AddedDate");
            DropColumn("dbo.Movies", "NoInStock");
        }
    }
}
