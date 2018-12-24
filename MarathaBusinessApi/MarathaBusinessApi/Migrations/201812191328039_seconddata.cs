namespace MarathaBusinessApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seconddata : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tblBusinessManRegistrations", "Status", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tblBusinessManRegistrations", "Status");
        }
    }
}
