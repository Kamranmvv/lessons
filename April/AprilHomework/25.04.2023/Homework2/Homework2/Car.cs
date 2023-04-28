using Homework2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    public class Car
    {
        public string City { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public ColorEnum Color { get; set; }
        public double EngineSize { get; set; }
        public int Horsepower { get; set; }
        public int Mileage { get; set; }
        public TransmissionTypeEnum TransmissionType { get; set; }
        public decimal Price { get; set; }

    }
}
