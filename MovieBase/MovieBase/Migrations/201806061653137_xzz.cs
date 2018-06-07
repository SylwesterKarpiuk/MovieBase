namespace MovieBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class xzz : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MovieDbs", "Added", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MovieDbs", "Added");
        }
    }
}
