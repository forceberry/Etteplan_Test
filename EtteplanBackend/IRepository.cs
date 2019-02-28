using EtteplanBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EtteplanBackend
{
    interface IRepository
    {
        IQueryable<Car> Get();
    }
}
