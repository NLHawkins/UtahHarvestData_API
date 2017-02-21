namespace UtahHarvestData_API.Migrations
{
    using Models;
    using System;
    using System.Data.Entity.Migrations;
    using System.IO;

    public partial class addedGoatCVS : DbMigration
    {

        public override void Up()
        {
            var systemPath = AppDomain.CurrentDomain.BaseDirectory + @"..\App_Data\GoatData.csv";
            var openFile = File.ReadAllLines(systemPath);

            using (var db = new ApplicationContext())
            {
                foreach (string row in openFile)
                {
                    var data = row.Split(',');
                    GoatHunt newGoatHunt = new GoatHunt
                    {
                        HuntId = data[0],
                        HuntType = data[1],
                        Permits = data[2],
                        HuntersAfield = data[3],
                        Harvest = data[4],
                        AvgDays = data[5],
                        SuccessRate = data[6]
                    };
                    db.GoatHunts.Add(newGoatHunt);
                }
                db.SaveChanges();
            }

            throw new Exception("no errors");
        }
        
        public override void Down()
        {
        }
    }
}
