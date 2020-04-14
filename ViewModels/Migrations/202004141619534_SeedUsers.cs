namespace ViewModels.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a835fb45-9e92-43cd-9951-999c9df5a529', N'siamislam1603@gmail.com', 0, N'AFe8rk3+yfW7lRdXTgaJ+nxYdeI9yBrhcPCVBkO3y8sZmIIcjezS5y8w/v9562BCGw==', N'54e647d4-b3f2-416b-a63a-22b7f1b0a64d', NULL, 0, 0, NULL, 1, 0, N'siamislam1603@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e01aec76-6abd-47d1-b558-47452e5ef59e', N'siamislam176854@gmail.com', 0, N'AKQWsZrwb6gCuQAUkRfzBcbjKGPugWiCZOQkMAF+G3mjMqhiTxrQIj7zy9KhNrY7yA==', N'1d82b474-4918-4698-89c5-21597f77b07d', NULL, 0, 0, NULL, 1, 0, N'siamislam176854@gmail.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'2892253f-eba0-4e2b-a044-d1555127daed', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a835fb45-9e92-43cd-9951-999c9df5a529', N'2892253f-eba0-4e2b-a044-d1555127daed')
");
        }
        
        public override void Down()
        {
        }
    }
}
