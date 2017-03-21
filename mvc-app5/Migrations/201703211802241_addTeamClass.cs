namespace mvc_app5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTeamClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        TeamId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        img = c.String(),
                        FacebookUrl = c.String(),
                        TwitterUrl = c.String(),
                        GooglePlusUrl = c.String(),
                    })
                .PrimaryKey(t => t.TeamId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Teams");
        }
    }
}
