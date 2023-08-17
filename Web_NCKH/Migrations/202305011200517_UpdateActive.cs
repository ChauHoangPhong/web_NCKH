namespace Web_NCKH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateActive : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Category", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.tb_New", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.tb_Project", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.tb_Recruitment", "Description", c => c.String());
            AddColumn("dbo.tb_Recruitment", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.tb_TopicCategory", "Link", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_TopicCategory", "Link");
            DropColumn("dbo.tb_Recruitment", "IsActive");
            DropColumn("dbo.tb_Recruitment", "Description");
            DropColumn("dbo.tb_Project", "IsActive");
            DropColumn("dbo.tb_New", "IsActive");
            DropColumn("dbo.tb_Category", "IsActive");
        }
    }
}
