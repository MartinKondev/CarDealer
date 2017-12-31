namespace TheCars.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TheCars.Data.Entities;

    internal sealed class Configuration : DbMigrationsConfiguration<CarsContext>
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

            var lada = new Make { Id = new Guid("406b216c-d11c-489b-a6f5-93595e03755e"), Name = "Lada" };
            var opel = new Make { Id = new Guid("a9c373b8-699e-4d70-a0d2-7fb8c07358c0"), Name = "Opel" };
            var moskovec = new Make { Id = new Guid("59010431-a0d7-4150-8509-72ac1b7a7ed8"), Name = "Moskvitch" };
            var ferari = new Make { Id = new Guid("8b819b20-b64b-45c5-8618-08f1fa78784c"), Name = "Ferarri" };
            var jugan = new Make { Id = new Guid("cfeaef1b-b7b5-4e4c-a663-873fae164995"), Name = "Jiguli" };
            var kitai = new Make { Id = new Guid("92cf7f81-def2-45ae-8a8c-f3135a712bd1"), Name = "Great Wall" };

            context.Makes.AddOrUpdate(x => x.Id,
                lada, opel, moskovec, ferari, jugan, kitai                
            );

            var m = new Model { Id = new Guid("65f26ded-d6a4-4e3d-ae8b-ff3852ee67ec"), Name = "Niva", Make = lada };
            var m1 = new Model { Id = new Guid("75f26ded-d6a4-4e3d-ae8b-ff3852ee67ec"), Name = "Samara", Make = lada };
            var m2 = new Model { Id = new Guid("339be76e-ef1b-4bd3-b8c5-3807665c829c"), Name = "Vectra", Make = opel };
            var m3 = new Model { Id = new Guid("439be76e-ef1b-4bd3-b8c5-3807665c829c"), Name = "Astra", Make = opel };
            var m4 = new Model { Id = new Guid("a72f1a9b-aa6f-4fe1-aba7-d16a3118a63e"), Name = "Osmica", Make = moskovec };
            var m5 = new Model { Id = new Guid("b72f1a9b-aa6f-4fe1-aba7-d16a3118a63e"), Name = "Dvanaisetica", Make = moskovec };
            var m6 = new Model { Id = new Guid("ee0dec9c-c574-4c69-a81a-58903173e1aa"), Name = "A123", Make = ferari };
            var m7 = new Model { Id = new Guid("fe0dec9c-c574-4c69-a81a-58903173e1aa"), Name = "Avfh892", Make = ferari };
            var m8 = new Model { Id = new Guid("61262cb1-d734-46f6-bc5b-188502bd6a6b"), Name = "8", Make = jugan };
            var m10 = new Model { Id = new Guid("71262cb1-d734-46f6-bc5b-188502bd6a6b"), Name = "6asdf", Make = jugan };
            var m11 = new Model { Id = new Guid("5c7b1f20-2e99-4125-9085-89eedf942a54"), Name = "Hunter", Make = kitai };
            var m12 = new Model { Id = new Guid("6c7b1f20-2e99-4125-9085-89eedf942a54"), Name = "5asdff", Make = kitai };


            context.Models.AddOrUpdate(x => x.Id,
                m, m1, m2, m3, m4, m5, m6, m7, m8, m12, m10, m11
            );

            context.Cars.AddOrUpdate(x => x.Id,
                new Car { Id = new Guid("43a50a21-77bf-4d7a-b9c5-e08b8134575c"), AutomaticGear = true, EngineSize = 2.8, Extras = null, FuelType = context.FuelTypes.Find(1), Is4x4 = true, IsNew = true, Location = context.Locations.Find(1), SeatsCount = 4, Weight = 1100, YearManifactured = 1990, Make = lada, Model=m },
                new Car { Id = new Guid("ef1d3c3f-eea3-475c-a9f7-7fdcdd3c7067"), AutomaticGear = true, EngineSize = 2.8, Extras = null, FuelType = context.FuelTypes.Find(1), Is4x4 = true, IsNew = true, Location = context.Locations.Find(1), SeatsCount = 4, Weight = 1100, YearManifactured = 1995, Make = lada, Model=m1 },
                new Car { Id = new Guid("0110aa97-cb2b-4344-bb0e-3d5236ed79bd"), AutomaticGear = true, EngineSize = 2.8, Extras = null, FuelType = context.FuelTypes.Find(1), Is4x4 = true, IsNew = true, Location = context.Locations.Find(2), SeatsCount = 4, Weight = 1100, YearManifactured = 1995, Make = opel, Model=m2 },
                new Car { Id = new Guid("de04b758-db2a-4608-8385-d8b4663ffc39"), AutomaticGear = true, EngineSize = 2.8, Extras = null, FuelType = context.FuelTypes.Find(1), Is4x4 = true, IsNew = true, Location = context.Locations.Find(2), SeatsCount = 4, Weight = 1100, YearManifactured = 1995, Make = opel, Model=m2 },
                new Car { Id = new Guid("8320132a-0ea0-46d5-b735-6923b4c464b4"), AutomaticGear = true, EngineSize = 2.4, Extras = null, FuelType = context.FuelTypes.Find(2), Is4x4 = true, IsNew = true, Location = context.Locations.Find(2), SeatsCount = 4, Weight = 1100, YearManifactured = 1995, Make = opel, Model = m3 },
                new Car { Id = new Guid("4dda88cc-8f8e-49dc-a01e-ccc41fccb34a"), AutomaticGear = true, EngineSize = 2.4, Extras = null, FuelType = context.FuelTypes.Find(2), Is4x4 = true, IsNew = true, Location = context.Locations.Find(1), SeatsCount = 4, Weight = 1100, YearManifactured = 1995, Make = opel, Model = m2 },
                new Car { Id = new Guid("2c51ee8f-21a9-4390-bea2-fedfc67d2ff0"), AutomaticGear = true, EngineSize = 2.4, Extras = null, FuelType = context.FuelTypes.Find(2), Is4x4 = true, IsNew = true, Location = context.Locations.Find(3), SeatsCount = 4, Weight = 1100, YearManifactured = 1995, Make = opel, Model = m3 },
                new Car { Id = new Guid("1352d9fc-cd83-459e-ac62-d735a13c66cb"), AutomaticGear = true, EngineSize = 2.4, Extras = null, FuelType = context.FuelTypes.Find(2), Is4x4 = true, IsNew = true, Location = context.Locations.Find(3), SeatsCount = 4, Weight = 1100, YearManifactured = 2010, Make = opel, Model = m2 },
                new Car { Id = new Guid("f812f6ab-5501-4339-b1ab-65dfabfc7547"), AutomaticGear = true, EngineSize = 1.4, Extras = null, FuelType = context.FuelTypes.Find(2), Is4x4 = true, IsNew = true, Location = context.Locations.Find(3), SeatsCount = 4, Weight = 1100, YearManifactured = 2010, Make = ferari, Model = m6 },
                new Car { Id = new Guid("9cca50c2-678f-418e-929c-6bd87b71df51"), AutomaticGear = true, EngineSize = 1.8, Extras = null, FuelType = context.FuelTypes.Find(3), Is4x4 = true, IsNew = true, Location = context.Locations.Find(3), SeatsCount = 4, Weight = 1100, YearManifactured = 2010, Make = ferari, Model = m6 },
                new Car { Id = new Guid("474fe4d6-d265-454b-ad27-f799269bc4ce"), AutomaticGear = true, EngineSize = 1.8, Extras = null, FuelType = context.FuelTypes.Find(3), Is4x4 = true, IsNew = true, Location = context.Locations.Find(4), SeatsCount = 4, Weight = 1100, YearManifactured = 2010, Make = ferari, Model = m7 },
                new Car { Id = new Guid("1bb0ab26-572c-4919-9ea2-d8f451e14b0a"), AutomaticGear = true, EngineSize = 1.8, Extras = null, FuelType = context.FuelTypes.Find(3), Is4x4 = true, IsNew = true, Location = context.Locations.Find(4), SeatsCount = 4, Weight = 1100, YearManifactured = 2010, Make = ferari, Model = m7 },
                new Car { Id = new Guid("1095aa89-9907-4090-b08a-8e8a35c43572"), AutomaticGear = false, EngineSize = 2.8, Extras = null, FuelType = context.FuelTypes.Find(4), Is4x4 = false, IsNew = false, Location = context.Locations.Find(5), SeatsCount = 2, Weight = 1100, YearManifactured = 1980, Make = moskovec, Model = m2 },
                new Car { Id = new Guid("44c2259e-dfaf-49dd-8dc0-cceed9fceb5a"), AutomaticGear = false, EngineSize = 2.8, Extras = null, FuelType = context.FuelTypes.Find(4), Is4x4 = false, IsNew = false, Location = context.Locations.Find(5), SeatsCount = 2, Weight = 1100, YearManifactured = 1980, Make = moskovec, Model = m2 },
                new Car { Id = new Guid("71b386a3-733a-4373-b2e5-df5fcf50a7ed"), AutomaticGear = false, EngineSize = 1.8, Extras = null, FuelType = context.FuelTypes.Find(4), Is4x4 = false, IsNew = false, Location = context.Locations.Find(5), SeatsCount = 2, Weight = 1100, YearManifactured = 1980, Make = moskovec, Model = m3 },
                new Car { Id = new Guid("7f524090-c132-4f0a-a37f-fb93a0e5726d"), AutomaticGear = false, EngineSize = 1.8, Extras = null, FuelType = context.FuelTypes.Find(4), Is4x4 = false, IsNew = false, Location = context.Locations.Find(5), SeatsCount = 2, Weight = 1100, YearManifactured = 1980, Make = moskovec, Model = m3 },
                new Car { Id = new Guid("df4b3c3e-a7a5-4ec1-8ba2-67c7675b09d2"), AutomaticGear = false, EngineSize = 1.8, Extras = null, FuelType = context.FuelTypes.Find(1), Is4x4 = false, IsNew = false, Location = context.Locations.Find(6), SeatsCount = 2, Weight = 1100, YearManifactured = 1987, Make = kitai, Model = m11 },
                new Car { Id = new Guid("df9d96ed-997f-4fcb-8411-724127f475d9"), AutomaticGear = false, EngineSize = 1.7, Extras = null, FuelType = context.FuelTypes.Find(5), Is4x4 = false, IsNew = false, Location = context.Locations.Find(6), SeatsCount = 2, Weight = 1100, YearManifactured = 1987, Make = kitai, Model = m12 },
                new Car { Id = new Guid("bbcb469d-90b7-40ce-b78a-fee505308e32"), AutomaticGear = false, EngineSize = 1.7, Extras = null, FuelType = context.FuelTypes.Find(5), Is4x4 = false, IsNew = false, Location = context.Locations.Find(6), SeatsCount = 6, Weight = 1100, YearManifactured = 1987, Make = kitai, Model = m11 },
                new Car { Id = new Guid("779cc3bf-1672-4ef5-a2a6-e9d2280d0e1a"), AutomaticGear = false, EngineSize = 1.7, Extras = null, FuelType = context.FuelTypes.Find(5), Is4x4 = false, IsNew = false, Location = context.Locations.Find(6), SeatsCount = 6, Weight = 1100, YearManifactured = 1987, Make = kitai, Model = m12 },
                new Car { Id = new Guid("456bdd2b-e70c-499e-b484-4e061a2b3c43"), AutomaticGear = false, EngineSize = 2.7, Extras = null, FuelType = context.FuelTypes.Find(5), Is4x4 = false, IsNew = false, Location = context.Locations.Find(7), SeatsCount = 6, Weight = 1100, YearManifactured = 1980, Make = kitai, Model = m11 },
                new Car { Id = new Guid("55ea5d69-5f3d-41a9-be7e-f8aa818b4cb7"), AutomaticGear = false, EngineSize = 3.7, Extras = null, FuelType = context.FuelTypes.Find(5), Is4x4 = false, IsNew = false, Location = context.Locations.Find(7), SeatsCount = 6, Weight = 1100, YearManifactured = 1980, Make = kitai, Model = m12 },
                new Car { Id = new Guid("d9cf2a3b-e0d9-4269-acaf-1f7a9207a857"), AutomaticGear = false, EngineSize = 3.7, Extras = null, FuelType = context.FuelTypes.Find(5), Is4x4 = false, IsNew = false, Location = context.Locations.Find(8), SeatsCount = 6, Weight = 1100, YearManifactured = 1980, Make = kitai, Model = m11 },
                new Car { Id = new Guid("b322413b-f4ad-461f-8042-978400ea4587"), AutomaticGear = false, EngineSize = 3.8, Extras = null, FuelType = context.FuelTypes.Find(5), Is4x4 = false, IsNew = false, Location = context.Locations.Find(9), SeatsCount = 30, Weight = 5100, YearManifactured = 2012, Make = lada, Model = m },
                new Car { Id = new Guid("4660ccf2-a475-485c-abbf-499e4fdaf8b8"), AutomaticGear = false, EngineSize = 2.8, Extras = null, FuelType = context.FuelTypes.Find(5), Is4x4 = true, IsNew = false, Location = context.Locations.Find(10), SeatsCount = 30, Weight = 5100, YearManifactured = 2012, Make = lada, Model = m1 },
                new Car { Id = new Guid("278e6f20-a55f-4920-93d9-2fbdb2e56d80"), AutomaticGear = false, EngineSize = 2.8, Extras = null, FuelType = context.FuelTypes.Find(5), Is4x4 = true, IsNew = false, Location = context.Locations.Find(11), SeatsCount = 30, Weight = 5100, YearManifactured = 2012, Make = lada, Model = m },
                new Car { Id = new Guid("e1c8c0ee-285e-43a0-a202-e133f4933ae2"), AutomaticGear = false, EngineSize = 4.6, Extras = null, FuelType = context.FuelTypes.Find(1), Is4x4 = true, IsNew = false, Location = context.Locations.Find(11), SeatsCount = 4, Weight = 1100, YearManifactured = 1990, Make = lada, Model = m1 }
            );
        }
    }
}































