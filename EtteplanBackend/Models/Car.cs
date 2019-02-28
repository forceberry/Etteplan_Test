using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EtteplanBackend.Models
{
    public class Car
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string RegisterId { get; set; }
        public int Year { get; set; }
        public DateTime InspectionDate { get; set; }
        public double EngineDisplacement { get; set; }
        public int EnginePower { get; set; }

    }
}
