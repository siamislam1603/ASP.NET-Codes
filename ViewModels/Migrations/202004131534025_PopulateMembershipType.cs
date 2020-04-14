namespace ViewModels.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into membershiptypes (signupfee,durationInMonths,discountRate,name) Values(0,0,0,'Pay as you go')");
            Sql("Insert into membershiptypes (signupfee,durationInMonths,discountRate,name) Values(30,1,10,'Monthly')");
            Sql("Insert into membershiptypes (signupfee,durationInMonths,discountRate,name) Values(90,3,15,'Quarterly')");
            Sql("Insert into membershiptypes (signupfee,durationInMonths,discountRate,name) Values(300,12,20,'Annual')");
        }
        
        public override void Down()
        {
        }
    }
}
