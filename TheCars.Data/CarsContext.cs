using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Configuration;
using TheCars.Data.Entities;

namespace TheCars.Data
{
    public class CarsContext : DbContext
    {
        //private static readonly string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        //private static readonly string connectionString = "Data Source=./SQLEXPRESS;Initial Catalog=CarsMarto;Integrated Security=True;";
        private static readonly string connectionString = "Server=.;Database=CarsMarto;Trusted_Connection=True;";

        public DbSet<Caravan> Caravans { get; set; }

        public DbSet<Bicycle> Bicycles { get; set; }

        public DbSet<Motorcycle> Motorcycles { get; set; }

        public DbSet<Car> Cars { get; set; }

        public DbSet<FuelType> FuelTypes { get; set; }

        public DbSet<Location> Locations { get; set; }

        public DbSet<VehicleExtra> VehicleExtras { get; set; }

        public DbSet<Make> Makes { get; set; }

        public DbSet<Model> Models { get; set; }

        public CarsContext() : base(connectionString)
        {
        }
    }
}
