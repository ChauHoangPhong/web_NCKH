namespace Web_NCKH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Achievements", "Alias", c => c.String(nullable: false, maxLength: 150));
            AddColumn("dbo.tb_Category", "Alias", c => c.String());
            AddColumn("dbo.tb_Member", "Alias", c => c.String());
            AddColumn("dbo.tb_Project", "Alias", c => c.String());
            AddColumn("dbo.tb_Recruitment", "Alias", c => c.String());
            AlterColumn("dbo.tb_Achievements", "Details", c => c.String());
            AlterColumn("dbo.tb_Category", "Description", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tb_Category", "Description", c => c.String(maxLength: 150));
            AlterColumn("dbo.tb_Achievements", "Details", c => c.String(nullable: false, maxLength: 150));
            DropColumn("dbo.tb_Recruitment", "Alias");
            DropColumn("dbo.tb_Project", "Alias");
            DropColumn("dbo.tb_Member", "Alias");
            DropColumn("dbo.tb_Category", "Alias");
            DropColumn("dbo.tb_Achievements", "Alias");
        }
    }
}
