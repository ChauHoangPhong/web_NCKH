namespace Web_NCKH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateAlias : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Achievements", "Title", c => c.String(nullable: false, maxLength: 150));
            AddColumn("dbo.tb_AchievementsCategory", "Alias", c => c.String());
            AddColumn("dbo.tb_AchievementsDate", "Alias", c => c.String());
            AlterColumn("dbo.tb_Achievements", "Alias", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tb_Achievements", "Alias", c => c.String(nullable: false, maxLength: 150));
            DropColumn("dbo.tb_AchievementsDate", "Alias");
            DropColumn("dbo.tb_AchievementsCategory", "Alias");
            DropColumn("dbo.tb_Achievements", "Title");
        }
    }
}
