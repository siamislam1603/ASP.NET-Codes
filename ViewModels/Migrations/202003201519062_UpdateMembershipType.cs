namespace ViewModels.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("update Membershiptypes set name='Pay as You Go' where id=1");
            Sql("update Membershiptypes set name='Monthly' where id=2");
        }
        
        public override void Down()
        {
        }
    }
}
