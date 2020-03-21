namespace ViewModels.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateBirthdate : DbMigration
    {
        public override void Up()
        {
            Sql("Update Customers Set birthdate='1998-11-14' where id=3");
        }
        
        public override void Down()
        {
        }
    }
}
