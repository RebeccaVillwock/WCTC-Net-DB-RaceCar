using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    class Toyota : RaceCar
    {
        public Toyota()
        {
            Name = "Toyota";
            TopSpeed = 95;
        }
        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} hums to life.");
        }
        
        public override void Brake()
        {
            Console.WriteLine($"The {Name} has slid to a stop in position {Position}");
         
        }
    }
}
