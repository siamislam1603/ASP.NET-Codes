namespace ViewModels.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenre : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Genres values('Action')");
            Sql("Insert into Genres values('Comedy')");
            Sql("Insert into Genres values('Romance')");
            Sql("Insert into Genres values('Family')");
        }
        
        public override void Down()
        {
        }
    }
}
