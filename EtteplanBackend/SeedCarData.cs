using EtteplanBackend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EtteplanBackend
{
    public class SeedCarData
    {
        public void CreateSeedCars()
        {
            var builder = new DbContextOptionsBuilder<CarDbContext>();
            builder.UseInMemoryDatabase("CarsDb");
            var options = builder.Options;

            using (var context = new CarDbContext(options))
            {
                var cars = new List<Car>
            {
                new Car { Manufacturer= "Skoda", Model= "Perusmalli", RegisterId= "ABC-987", Year = 2012, EngineDisplacement=1800, EnginePower=70},
                new Car { Manufacturer= "Audi", Model= "Bisnesmalli", RegisterId= "DEF-543", Year = 2015, EngineDisplacement=2100, EnginePower=110},
                new Car { Manufacturer= "Volkswagen", Model= "Pakettiauto", RegisterId= "GHI-876", Year = 2008, EngineDisplacement=2000, EnginePower=960},
                };

                context.AddRange(cars);
                context.SaveChanges();
            }

            using (var context = new CarDbContext(options))
            {
                var repository = new Repository(context);
                var getnewcars = repository.GetNewCars();
            }
        }
    }
}
