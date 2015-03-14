namespace GetYourlLine.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CustomerDetails",
                c => new
                    {
                        CustomerDetailID = c.Int(nullable: false, identity: true),
                        CustomerID = c.Int(nullable: false),
                        DateTime = c.String(),
                        RegisteredTime = c.String(),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.CustomerDetailID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerID = c.Int(nullable: false, identity: true),
                        Service = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        CustomerDetails_CustomerDetailID = c.Int(),
                    })
                .PrimaryKey(t => t.CustomerID)
                .ForeignKey("dbo.CustomerDetails", t => t.CustomerDetails_CustomerDetailID)
                .Index(t => t.CustomerDetails_CustomerDetailID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "CustomerDetails_CustomerDetailID", "dbo.CustomerDetails");
            DropIndex("dbo.Customers", new[] { "CustomerDetails_CustomerDetailID" });
            DropTable("dbo.Customers");
            DropTable("dbo.CustomerDetails");
        }
    }
}
