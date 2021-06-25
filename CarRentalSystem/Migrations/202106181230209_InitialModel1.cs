namespace CarRentalSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tbl_Admin",
                c => new
                    {
                        AdminId = c.Int(nullable: false, identity: true),
                        AdminName = c.String(nullable: false, maxLength: 50),
                        Address = c.String(maxLength: 300),
                        PhoneNumber = c.Long(nullable: false),
                        EmailId = c.String(nullable: false, maxLength: 100),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.AdminId);
            
            CreateTable(
                "dbo.tbl_Car",
                c => new
                    {
                        CarId = c.Int(nullable: false, identity: true),
                        CarName = c.String(nullable: false, maxLength: 255),
                        CarType = c.String(nullable: false, maxLength: 255),
                        DefaultPrice = c.Double(nullable: false),
                        CarOwnwerId = c.Int(nullable: false),
                        OwnerId = c.Int(nullable: false),
                        AdminId = c.Int(nullable: false),
                        CarRental_RentalId = c.Int(),
                    })
                .PrimaryKey(t => t.CarId)
                .ForeignKey("dbo.tbl_Admin", t => t.AdminId)
                .ForeignKey("dbo.tbl_Owner", t => t.OwnerId)
                .ForeignKey("dbo.tbl_Rental", t => t.CarRental_RentalId)
                .Index(t => t.OwnerId)
                .Index(t => t.AdminId)
                .Index(t => t.CarRental_RentalId);
            
            CreateTable(
                "dbo.tbl_Owner",
                c => new
                    {
                        OwnerId = c.Int(nullable: false, identity: true),
                        OwnerName = c.String(nullable: false, maxLength: 50),
                        Address = c.String(nullable: false, maxLength: 300),
                        PhoneNumber = c.Long(nullable: false),
                        EmailId = c.String(nullable: false, maxLength: 100),
                        Password = c.String(nullable: false),
                        AdminId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OwnerId)
                .ForeignKey("dbo.tbl_Admin", t => t.AdminId)
                .Index(t => t.AdminId);
            
            CreateTable(
                "dbo.tbl_Rental",
                c => new
                    {
                        RentalId = c.Int(nullable: false, identity: true),
                        PickupDate = c.DateTime(nullable: false),
                        ReturnDate = c.DateTime(nullable: false),
                        Source = c.String(nullable: false, maxLength: 255),
                        Destination = c.String(nullable: false, maxLength: 255),
                        FairAmount = c.Double(nullable: false),
                        InitialFuel = c.String(nullable: false),
                        AdminId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RentalId)
                .ForeignKey("dbo.tbl_Admin", t => t.AdminId)
                .Index(t => t.AdminId);
            
            CreateTable(
                "dbo.tbl_Customer",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(nullable: false, maxLength: 50),
                        Address = c.String(nullable: false, maxLength: 300),
                        PhoneNumber = c.Long(nullable: false),
                        EmailId = c.String(nullable: false, maxLength: 100),
                        Password = c.String(nullable: false),
                        RentalId = c.Int(nullable: false),
                        AdminId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerId)
                .ForeignKey("dbo.tbl_Admin", t => t.AdminId)
                .ForeignKey("dbo.tbl_Rental", t => t.RentalId)
                .Index(t => t.RentalId)
                .Index(t => t.AdminId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tbl_Customer", "RentalId", "dbo.tbl_Rental");
            DropForeignKey("dbo.tbl_Customer", "AdminId", "dbo.tbl_Admin");
            DropForeignKey("dbo.tbl_Car", "CarRental_RentalId", "dbo.tbl_Rental");
            DropForeignKey("dbo.tbl_Rental", "AdminId", "dbo.tbl_Admin");
            DropForeignKey("dbo.tbl_Car", "OwnerId", "dbo.tbl_Owner");
            DropForeignKey("dbo.tbl_Owner", "AdminId", "dbo.tbl_Admin");
            DropForeignKey("dbo.tbl_Car", "AdminId", "dbo.tbl_Admin");
            DropIndex("dbo.tbl_Customer", new[] { "AdminId" });
            DropIndex("dbo.tbl_Customer", new[] { "RentalId" });
            DropIndex("dbo.tbl_Rental", new[] { "AdminId" });
            DropIndex("dbo.tbl_Owner", new[] { "AdminId" });
            DropIndex("dbo.tbl_Car", new[] { "CarRental_RentalId" });
            DropIndex("dbo.tbl_Car", new[] { "AdminId" });
            DropIndex("dbo.tbl_Car", new[] { "OwnerId" });
            DropTable("dbo.tbl_Customer");
            DropTable("dbo.tbl_Rental");
            DropTable("dbo.tbl_Owner");
            DropTable("dbo.tbl_Car");
            DropTable("dbo.tbl_Admin");
        }
    }
}
