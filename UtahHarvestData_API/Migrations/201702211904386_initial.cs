namespace UtahHarvestData_API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GoatHunts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HuntId = c.Int(nullable: false),
                        HuntType = c.String(),
                        Permits = c.Int(nullable: false),
                        HuntersAfield = c.Int(nullable: false),
                        Harvest = c.Int(nullable: false),
                        AvgDays = c.Double(nullable: false),
                        SuccessRate = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.GoatHunts");
        }
    }
}
