namespace mvc_app5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addImageToService : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OurServices", "img", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.OurServices", "img");
        }
    }
}
