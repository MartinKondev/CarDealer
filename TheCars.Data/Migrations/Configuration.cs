namespace TheCars.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TheCars.Data.Entities;

    internal sealed class Configuration : DbMigrationsConfiguration<TheCars.Data.CarsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CarsContext context)
        {
            context.Locations.AddOrUpdate(x => x.Id,
                new Location { Id=1, Name = "Sofia" },
                new Location { Id=2, Name = "Plovdiv" },
                new Location { Id=3, Name = "Varna" },
                new Location { Id=4, Name = "Bourgas" },
                new Location { Id=5, Name = "Sliven" },
                new Location { Id=6, Name = "Yambol" },
                new Location { Id=7, Name = "Haskovo" },
                new Location { Id=8, Name = "Pernik" },
                new Location { Id=9, Name = "Mernik" },
                new Location { Id=10, Name = "Pleven" },
                new Location { Id = 11, Name = "Other" }
            );

            context.FuelTypes.AddOrUpdate(x => x.Id,
                 new FuelType {Id = 1, Name = "Diesel" },
                 new FuelType {Id = 2, Name = "Benzin" },
                 new FuelType {Id = 3, Name = "Hybrid" },
                 new FuelType {Id = 4, Name = "Electricity" },
                 new FuelType {Id = 5, Name = "Other" }
            );


        }
    }
}
