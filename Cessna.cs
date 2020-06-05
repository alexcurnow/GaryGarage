using System;

namespace GaryGarage
{
    public class Cessna : Vehicle, IGasVehicle
    {
        double FuelCapacity { get; set; }
        public int CurrentTankPercentage { get; set; } = 50;
        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
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