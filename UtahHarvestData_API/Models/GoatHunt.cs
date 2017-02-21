using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UtahHarvestData_API.Models
{
    public class GoatHunt
    {
        public int Id { get; set; }
        public string HuntId { get; set; }
        public string HuntType { get; set; }
        public string Permits { get; set; }
        public string HuntersAfield { get; set; }
        public string Harvest { get; set; }
        public string AvgDays { get; set; }
        public string SuccessRate { get; set; }

    }
}