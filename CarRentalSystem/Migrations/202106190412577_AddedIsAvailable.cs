namespace CarRentalSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedIsAvailable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tbl_Car", "IsAvailable", c => c.Boolean(nullable: false));
            AlterColumn("dbo.tbl_Rental", "InitialFuel", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tbl_Rental", "InitialFuel", c => c.String(nullable: false));
            DropColumn("dbo.tbl_Car", "IsAvailable");
        }
    }
}
