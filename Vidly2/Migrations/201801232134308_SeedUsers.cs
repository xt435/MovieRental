namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'34b5fe95-b15d-41d4-835e-730e0a9aaa5e', N'guest@sean.com', 0, N'ANPHtA1bRDYlEf39KgzDG2hXm4RtKzf1mj2COfpYRpiT9gvtxY25nyMdOZ3Kp2ZHmg==', N'348fea52-e06b-42d8-8f12-ac6e4581f8a7', NULL, 0, 0, NULL, 1, 0, N'guest@sean.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd0b45688-2360-4515-bc52-f581a440ebad', N'Admin@sean.com', 0, N'APPs3wD9+DqF2zkNVUdZ3Q/keThjoa9QWFH8EjLT139zYXxfXChBO/zdJ2oprHwzvg==', N'e9c32290-a365-4112-aa1a-c0fb9b351810', NULL, 0, 0, NULL, 1, 0, N'Admin@sean.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'4898e1d2-b6db-4fa2-a85c-f3a6e6b73c4d', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'd0b45688-2360-4515-bc52-f581a440ebad', N'4898e1d2-b6db-4fa2-a85c-f3a6e6b73c4d')

");
        }
        
        public override void Down()
        {
        }
    }
}
