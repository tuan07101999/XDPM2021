namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DataAccess.RentingDiskDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DataAccess.RentingDiskDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            var listDisk = context.Disks.ToList();
            foreach (var item in listDisk)
            {
                item.name = item.idDisk + " - " + context.Titles.FirstOrDefault(x => x.idTitle == item.idTitle).name;
            }
            context.SaveChanges();
        }
    }
}
