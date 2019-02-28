using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EtteplanBackend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EtteplanBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {

        private readonly IRepository _repo;

        public CarsController(Repository repo)
        {
            _repo = repo;
        }

        // GET: api/Cars
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repo.Get());
        }

        // GET: api/Cars/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Cars
        [HttpPost]
        public void Post([FromBody] Car car)
        {
        }

        // PUT: api/Cars/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        [HttpGet, Route("seed")]
        public string CreateSeed()
        {
            var seed = new SeedCarData();
            seed.CreateSeedCars();
            return "Seed created";
        }
    }
}
