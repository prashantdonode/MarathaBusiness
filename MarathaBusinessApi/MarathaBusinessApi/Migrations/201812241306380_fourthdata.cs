namespace MarathaBusinessApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fourthdata : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tblBusinessManRegistrations", "NameofBusiness", c => c.String());
            AddColumn("dbo.tblBusinessManRegistrations", "TypeofBusiness", c => c.String());
            AddColumn("dbo.tblBusinessManRegistrations", "Contact", c => c.String());
            AddColumn("dbo.tblBusinessManRegistrations", "Website", c => c.String());
            AddColumn("dbo.tblBusinessManRegistrations", "AboutBusiness", c => c.String());
            AddColumn("dbo.tblBusinessManRegistrations", "Services", c => c.String());
            AddColumn("dbo.tblBusinessManRegistrations", "BestPrice", c => c.String());
            DropColumn("dbo.tblBusinessManRegistrations", "MobileNo");
            DropColumn("dbo.tblBusinessManRegistrations", "PhoneNo");
            DropColumn("dbo.tblBusinessManRegistrations", "Occupation");
            DropColumn("dbo.tblBusinessManRegistrations", "StoreName");
            DropColumn("dbo.tblBusinessManRegistrations", "City");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tblBusinessManRegistrations", "City", c => c.String());
            AddColumn("dbo.tblBusinessManRegistrations", "StoreName", c => c.String());
            AddColumn("dbo.tblBusinessManRegistrations", "Occupation", c => c.String());
            AddColumn("dbo.tblBusinessManRegistrations", "PhoneNo", c => c.String());
            AddColumn("dbo.tblBusinessManRegistrations", "MobileNo", c => c.String());
            DropColumn("dbo.tblBusinessManRegistrations", "BestPrice");
            DropColumn("dbo.tblBusinessManRegistrations", "Services");
            DropColumn("dbo.tblBusinessManRegistrations", "AboutBusiness");
            DropColumn("dbo.tblBusinessManRegistrations", "Website");
            DropColumn("dbo.tblBusinessManRegistrations", "Contact");
            DropColumn("dbo.tblBusinessManRegistrations", "TypeofBusiness");
            DropColumn("dbo.tblBusinessManRegistrations", "NameofBusiness");
        }
    }
}
