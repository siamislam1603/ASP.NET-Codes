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
            Sql("Update movies set genreid=1 where id=1");
            Sql("Update movies set genreid=2 where id=2");
        }
        
        public override void Down()
        {
        }
    }
}
