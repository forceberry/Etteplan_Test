using EtteplanBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EtteplanBackend
{
    public class Repository : IRepository
    {
        private readonly CarDbContext _context;

        public Repository(CarDbContext context)
        {
            _context = context;
        }

        public void Add(Car car)
        {
            _context.Cars.Add(car);
        }

        public IQueryable<Car> Get()
        {
            return _context.Cars;
        }

        public IQueryable<Car> GetNewCars()
        {
            return _context.Cars.Where(g => g.Year >= 2010);
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
