namespace MarathaBusinessApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fifthdata : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tblBusinessManRegistrations", "Document", c => c.Binary());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tblBusinessManRegistrations", "Document", c => c.Byte(nullable: false));
        }
    }
}
