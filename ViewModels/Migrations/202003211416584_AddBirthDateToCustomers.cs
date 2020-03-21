namespace ViewModels.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirthDateToCustomers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "birthdate", c => c.DateTime(nullable:true,defaultValue:null));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "birthdate");
        }
    }
}
