namespace ViewModels.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into membershiptypes (id,signupfee,durationInMonths,discountRate) Values(1,0,0,0)");
            Sql("Insert into membershiptypes (id,signupfee,durationInMonths,discountRate) Values(2,30,1,10)");
            Sql("Insert into membershiptypes (id,signupfee,durationInMonths,discountRate) Values(3,90,3,15)");
            Sql("Insert into membershiptypes (id,signupfee,durationInMonths,discountRate) Values(4,300,12,20)");
        }
        
        public override void Down()
        {
        }
    }
}
