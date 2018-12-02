namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'71950e25-8529-484e-97bf-6028ebe98e80', N'guest@gmail.com', 0, N'AFC1Uzp9LR7OTEw86B7uxpmVdfOQmT6wuWLH3JjYWNG+hwvVzoXb1D6tXI0j4KCosQ==', N'914fbec5-176c-4830-a77d-0184677fc65b', NULL, 0, 0, NULL, 1, 0, N'guest@gmail.com')
                  INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'7bc0ee42-0239-4063-8f70-927310481f1d', N'Admin@gmail.com', 0, N'AOVHlSEPGcYxZ9wyE1H+rX04DfZDkPvlYr70OE0srLVYiD2fxgNAmPtx8tXUhD2M+Q==', N'cfe66d87-e3a6-4e25-af74-4c3526e2979e', NULL, 0, 0, NULL, 1, 0, N'Admin@gmail.com')
                  INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'24ece28c-1a95-476a-8659-46beb439a280', N'CanManageMovies')
                  INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'71950e25-8529-484e-97bf-6028ebe98e80', N'24ece28c-1a95-476a-8659-46beb439a280')
");
        }
        
        public override void Down()
        {
        }
    }
}
