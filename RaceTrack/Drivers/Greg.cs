using RaceTrack.RaceTrack.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Drivers
{
    public class Greg : Driver
    {
        public Greg(RaceCar car) : base(car)
        {
            Name = "Greg";
            SkillLevel = 15;
        }
        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }
    }
}
