namespace ViewModels.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembershipType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MembershipTypes",
                c => new
                    {
                        id = c.Byte(nullable: false),
                        signUpFee = c.Short(nullable: false),
                        durationInMonths = c.Short(nullable: false),
                        discountRate = c.Short(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            AddColumn("dbo.Customers", "membershipTypeId", c => c.Boolean(nullable: false));
            AddColumn("dbo.Customers", "membershipType_id", c => c.Byte());
            CreateIndex("dbo.Customers", "membershipType_id");
            AddForeignKey("dbo.Customers", "membershipType_id", "dbo.MembershipTypes", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "membershipType_id", "dbo.MembershipTypes");
            DropIndex("dbo.Customers", new[] { "membershipType_id" });
            DropColumn("dbo.Customers", "membershipType_id");
            DropColumn("dbo.Customers", "membershipTypeId");
            DropTable("dbo.MembershipTypes");
        }
    }
}
