namespace MarathaBusinessApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class thirddatanew : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblSkyAdmins",
                c => new
                    {
                        Sid = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Sid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblSkyAdmins");
        }
    }
}
