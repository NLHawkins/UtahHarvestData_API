using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace UtahHarvestData_API.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<GoatHunt> GoatHunts { get; set; }
    }
}