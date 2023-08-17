namespace Web_NCKH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateLocation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_LocationCategory", "Alias", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_LocationCategory", "Alias");
        }
    }
}
