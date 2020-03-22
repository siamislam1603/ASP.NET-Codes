namespace ViewModels.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMoviesMoreInfo : DbMigration
    {
        public override void Up()
        {
            Sql("Update Movies set addedDate='"+DateTime.Now.ToString()+"',releaseDate='2022-10-11',noInStock=5 where id=1");
            Sql("Update Movies set addedDate='"+DateTime.Now.ToString()+"',releaseDate='2022-8-21',noInStock=3 where id=2");
        }
        
        public override void Down()
        {
        }
    }
}
