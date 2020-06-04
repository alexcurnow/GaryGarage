using System;

namespace GaryGarage
{
    public class Cessna : Vehicle
    {
        double FuelCapacity { get; set; }
        public void RefuelTank()
        {
            // noting yet...
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna swooshes overhead!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The Cessna glides {direction}");
        }

        public override void Stop()
        {
            Console.WriteLine($"The Cessna sticks the landing and slowly stops on the runway.");
        }

    }
}