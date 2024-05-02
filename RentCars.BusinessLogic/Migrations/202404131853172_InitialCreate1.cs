namespace RentCars.BusinessLogic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProductDbTables", "Image", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ProductDbTables", "Image");
        }
    }
}
