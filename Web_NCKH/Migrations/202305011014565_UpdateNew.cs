namespace Web_NCKH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateNew : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_New", "Alias", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_New", "Alias");
        }
    }
}
