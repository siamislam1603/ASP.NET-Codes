namespace ViewModels.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerIsAssocitedtoMembershipTypeId : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "membershipType_id", "dbo.MembershipTypes");
            DropIndex("dbo.Customers", new[] { "membershipType_id" });
            DropColumn("dbo.Customers", "membershipTypeId");
            RenameColumn(table: "dbo.Customers", name: "membershipType_id", newName: "membershipTypeId");
            AlterColumn("dbo.Customers", "membershipTypeId", c => c.Byte(nullable: false));
            AlterColumn("dbo.Customers", "membershipTypeId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Customers", "membershipTypeId");
            AddForeignKey("dbo.Customers", "membershipTypeId", "dbo.MembershipTypes", "id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "membershipTypeId", "dbo.MembershipTypes");
            DropIndex("dbo.Customers", new[] { "membershipTypeId" });
            AlterColumn("dbo.Customers", "membershipTypeId", c => c.Byte());
            AlterColumn("dbo.Customers", "membershipTypeId", c => c.Boolean(nullable: false));
            RenameColumn(table: "dbo.Customers", name: "membershipTypeId", newName: "membershipType_id");
            AddColumn("dbo.Customers", "membershipTypeId", c => c.Boolean(nullable: false));
            CreateIndex("dbo.Customers", "membershipType_id");
            AddForeignKey("dbo.Customers", "membershipType_id", "dbo.MembershipTypes", "id");
        }
    }
}
