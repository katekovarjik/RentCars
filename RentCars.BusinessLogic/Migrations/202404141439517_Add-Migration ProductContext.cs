namespace RentCars.BusinessLogic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMigrationProductContext : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ProductDbTables", "Image", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ProductDbTables", "Image", c => c.String(nullable: false));
        }
    }
}
