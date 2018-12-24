namespace MarathaBusinessApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstdata : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblBusinessManRegistrations",
                c => new
                    {
                        Bid = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        MobileNo = c.String(),
                        PhoneNo = c.String(),
                        Email = c.String(),
                        Occupation = c.String(),
                        StoreName = c.String(),
                        Address = c.String(),
                        City = c.String(),
                        Document = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Bid);
            
            CreateTable(
                "dbo.tblOccupations",
                c => new
                    {
                        Oid = c.Int(nullable: false, identity: true),
                        Occupation = c.String(),
                    })
                .PrimaryKey(t => t.Oid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblOccupations");
            DropTable("dbo.tblBusinessManRegistrations");
        }
    }
}
