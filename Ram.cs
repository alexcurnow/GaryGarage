using System;

namespace GaryGarage
{
    public class Ram : Vehicle, IGasVehicle
    {
        public double FuelCapacity { get; set; }
        public int CurrentTankPercentage { get; set; } = 35;
        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram rumbles by.");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The Ram takes a {direction} turn.");
        }
        public override void Stop()
        {
            Console.WriteLine($"The Ram comes to a rumbling stop.");
        }

    }
}