namespace Rently.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'597f3598-e174-4ffa-a2f7-a42e83fa9848', N'guest@rently.com', 0, N'AA7Zth+vaX5658lZZW+KJAZNUF8T1qY/VQCEPOYEc4heSQzBJtAsNOBXLA4KHdh96Q==', N'69368128-2e79-4058-8842-01dd39627993', NULL, 0, 0, NULL, 1, 0, N'guest@rently.com')
                  INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'6dcba6a1-0468-4aaf-9999-94f3f82ceab3', N'admin@rently.com', 0, N'ABEWgOT0/fPYN0AGTDQz3rWOvmPuLabyLHnGzBz9a/67UV2YhxHqKHIETZtBymbNZA==', N'6f67371d-94c9-414c-ae05-87ef8c933e9b', NULL, 0, 0, NULL, 1, 0, N'admin@rently.com')
                  INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'081b3f41-3756-43c7-9891-283ca845451a', N'ManagerCars')
                  INSERT INTO[dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES(N'6dcba6a1-0468-4aaf-9999-94f3f82ceab3', N'081b3f41-3756-43c7-9891-283ca845451a')");


        }

    public override void Down()
        {
        }
    }
}
