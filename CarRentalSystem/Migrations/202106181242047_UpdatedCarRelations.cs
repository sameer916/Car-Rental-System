namespace CarRentalSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedCarRelations : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.tbl_Car", new[] { "CarRental_RentalId" });
            RenameColumn(table: "dbo.tbl_Car", name: "CarRental_RentalId", newName: "RentalId");
            AlterColumn("dbo.tbl_Car", "RentalId", c => c.Int(nullable: false));
            CreateIndex("dbo.tbl_Car", "RentalId");
            DropColumn("dbo.tbl_Car", "CarOwnwerId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tbl_Car", "CarOwnwerId", c => c.Int(nullable: false));
            DropIndex("dbo.tbl_Car", new[] { "RentalId" });
            AlterColumn("dbo.tbl_Car", "RentalId", c => c.Int());
            RenameColumn(table: "dbo.tbl_Car", name: "RentalId", newName: "CarRental_RentalId");
            CreateIndex("dbo.tbl_Car", "CarRental_RentalId");
        }
    }
}
