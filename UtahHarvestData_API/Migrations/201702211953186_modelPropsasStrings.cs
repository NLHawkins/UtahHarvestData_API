namespace UtahHarvestData_API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modelPropsasStrings : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.GoatHunts", "HuntId", c => c.String());
            AlterColumn("dbo.GoatHunts", "Permits", c => c.String());
            AlterColumn("dbo.GoatHunts", "HuntersAfield", c => c.String());
            AlterColumn("dbo.GoatHunts", "Harvest", c => c.String());
            AlterColumn("dbo.GoatHunts", "AvgDays", c => c.String());
            AlterColumn("dbo.GoatHunts", "SuccessRate", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.GoatHunts", "SuccessRate", c => c.Double(nullable: false));
            AlterColumn("dbo.GoatHunts", "AvgDays", c => c.Double(nullable: false));
            AlterColumn("dbo.GoatHunts", "Harvest", c => c.Int(nullable: false));
            AlterColumn("dbo.GoatHunts", "HuntersAfield", c => c.Int(nullable: false));
            AlterColumn("dbo.GoatHunts", "Permits", c => c.Int(nullable: false));
            AlterColumn("dbo.GoatHunts", "HuntId", c => c.Int(nullable: false));
        }
    }
}
