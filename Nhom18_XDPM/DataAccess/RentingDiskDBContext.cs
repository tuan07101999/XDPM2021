using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class RentingDiskDBContext : DbContext
    {
        public RentingDiskDBContext() : base("DBConnectionString")
        {
            Configuration.LazyLoadingEnabled = true;
            Configuration.ProxyCreationEnabled = true;
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Title> Titles { get; set; }
        public DbSet<Disk> Disks { get; set; }
        public DbSet<Record> Records { get; set; }
        public DbSet<Holding> Holdings { get; set; }
    }
}
