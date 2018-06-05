namespace MovieBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class codefirst : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MovieDbs",
                c => new
                    {
                        MovieID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Description = c.String(),
                        Link = c.String(),
                        PictureLink = c.String(),
                    })
                .PrimaryKey(t => t.MovieID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MovieDbs");
        }
    }
}
