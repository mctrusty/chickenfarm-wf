namespace ChickenFarmWF.Migrations
{
    using ChickenFarmWF.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ChickenFarmWF.Models.FarmContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ChickenFarmWF.Models.FarmContext context)
        {
            context.Farmers.AddOrUpdate(
                new Farmer { FirstName = "Bob", LastName = "Dobbs", Year = License.Residential },
                new Farmer { FirstName = "Lars", LastName = "Jonnson", Year = License.Commercial }
                );
            context.SaveChanges();
        }
    }
}
