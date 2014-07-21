namespace ChickenFarmWF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Farmers",
                c => new
                    {
                        FarmerId = c.Int(nullable: false, identity: true),
                        LastName = c.String(nullable: false, maxLength: 40),
                        FirstName = c.String(nullable: false, maxLength: 20),
                        Year = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FarmerId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Farmers");
        }
    }
}
