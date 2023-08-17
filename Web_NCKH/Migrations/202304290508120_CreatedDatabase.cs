namespace Web_NCKH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatedDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tb_Achievements",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Details = c.String(nullable: false, maxLength: 150),
                        AchievementsDateID = c.Int(nullable: false),
                        AchievementsCategoryID = c.Int(nullable: false),
                        CreatedBy = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        ModifiedrDate = c.DateTime(nullable: false),
                        ModifierBy = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tb_AchievementsCategory", t => t.AchievementsCategoryID, cascadeDelete: true)
                .ForeignKey("dbo.tb_AchievementsDate", t => t.AchievementsDateID, cascadeDelete: true)
                .Index(t => t.AchievementsDateID)
                .Index(t => t.AchievementsCategoryID);
            
            CreateTable(
                "dbo.tb_AchievementsCategory",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 150),
                        CreatedBy = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        ModifiedrDate = c.DateTime(nullable: false),
                        ModifierBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tb_AchievementsDate",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.String(nullable: false, maxLength: 150),
                        CreatedBy = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        ModifiedrDate = c.DateTime(nullable: false),
                        ModifierBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tb_Adv",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 150),
                        Description = c.String(maxLength: 500),
                        Image = c.String(maxLength: 500),
                        Link = c.String(maxLength: 500),
                        Type = c.Int(nullable: false),
                        CreatedBy = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        ModifiedrDate = c.DateTime(nullable: false),
                        ModifierBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tb_Category",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        SeoTitle = c.String(),
                        SeoDescription = c.String(),
                        SeoKeywords = c.String(),
                        Position = c.Int(nullable: false),
                        CreatedBy = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        ModifiedrDate = c.DateTime(nullable: false),
                        ModifierBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tb_New",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 150),
                        Description = c.String(),
                        Detail = c.String(),
                        Image = c.String(),
                        Category = c.Int(nullable: false),
                        SeoTitle = c.String(),
                        SeoDescription = c.String(),
                        SeoKeywords = c.String(),
                        CreatedBy = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        ModifiedrDate = c.DateTime(nullable: false),
                        ModifierBy = c.String(),
                        Categori_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tb_Category", t => t.Categori_Id)
                .Index(t => t.Categori_Id);
            
            CreateTable(
                "dbo.tb_LocationCategory",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 150),
                        CreatedBy = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        ModifiedrDate = c.DateTime(nullable: false),
                        ModifierBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tb_Member",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 250),
                        Description = c.String(),
                        Detail = c.String(),
                        Link = c.String(),
                        LocationCategoryId = c.Int(nullable: false),
                        CreatedBy = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        ModifiedrDate = c.DateTime(nullable: false),
                        ModifierBy = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tb_LocationCategory", t => t.LocationCategoryId, cascadeDelete: true)
                .Index(t => t.LocationCategoryId);
            
            CreateTable(
                "dbo.tb_Project",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 250),
                        Description = c.String(),
                        Detail = c.String(),
                        Image = c.String(),
                        Link = c.String(),
                        CreatedBy = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        ModifiedrDate = c.DateTime(nullable: false),
                        ModifierBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tb_Recruitment",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 150),
                        Detail = c.String(),
                        Image = c.String(),
                        CreatedBy = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        ModifiedrDate = c.DateTime(nullable: false),
                        ModifierBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.tb_SystemSetting",
                c => new
                    {
                        SettingKey = c.String(nullable: false, maxLength: 50),
                        SettingValue = c.String(),
                        SettingDescription = c.String(),
                    })
                .PrimaryKey(t => t.SettingKey);
            
            CreateTable(
                "dbo.tb_TopicCategory",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 150),
                        Description = c.String(),
                        CreatedBy = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        ModifiedrDate = c.DateTime(nullable: false),
                        ModifierBy = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.tb_Member", "LocationCategoryId", "dbo.tb_LocationCategory");
            DropForeignKey("dbo.tb_New", "Categori_Id", "dbo.tb_Category");
            DropForeignKey("dbo.tb_Achievements", "AchievementsDateID", "dbo.tb_AchievementsDate");
            DropForeignKey("dbo.tb_Achievements", "AchievementsCategoryID", "dbo.tb_AchievementsCategory");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.tb_Member", new[] { "LocationCategoryId" });
            DropIndex("dbo.tb_New", new[] { "Categori_Id" });
            DropIndex("dbo.tb_Achievements", new[] { "AchievementsCategoryID" });
            DropIndex("dbo.tb_Achievements", new[] { "AchievementsDateID" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.tb_TopicCategory");
            DropTable("dbo.tb_SystemSetting");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.tb_Recruitment");
            DropTable("dbo.tb_Project");
            DropTable("dbo.tb_Member");
            DropTable("dbo.tb_LocationCategory");
            DropTable("dbo.tb_New");
            DropTable("dbo.tb_Category");
            DropTable("dbo.tb_Adv");
            DropTable("dbo.tb_AchievementsDate");
            DropTable("dbo.tb_AchievementsCategory");
            DropTable("dbo.tb_Achievements");
        }
    }
}
