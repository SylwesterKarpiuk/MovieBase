namespace MovieBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class codefirst1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MovieDbs", "Stars", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.MovieDbs", "Stars");
        }
    }
}
