using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalMarket.Db.Entityes.DbContexts
{
    public class MarketContext : DbContext
    {
        public DbSet<User> Users { get; set; } 
    }
}
