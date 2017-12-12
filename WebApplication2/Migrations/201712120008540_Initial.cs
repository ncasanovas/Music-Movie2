namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Moods",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Moods = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(),
                        Link = c.String(),
                        Mood_ID = c.Int(nullable: false),
                        Mood_ID1 = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Moods", t => t.Mood_ID1)
                .Index(t => t.Mood_ID1);
            
            CreateTable(
                "dbo.Songs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Artist = c.String(),
                        Link = c.String(),
                        Mood_ID = c.Int(nullable: false),
                        Mood_ID1 = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Moods", t => t.Mood_ID1)
                .Index(t => t.Mood_ID1);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Songs", "Mood_ID1", "dbo.Moods");
            DropForeignKey("dbo.Movies", "Mood_ID1", "dbo.Moods");
            DropIndex("dbo.Songs", new[] { "Mood_ID1" });
            DropIndex("dbo.Movies", new[] { "Mood_ID1" });
            DropTable("dbo.Songs");
            DropTable("dbo.Movies");
            DropTable("dbo.Moods");
        }
    }
}
