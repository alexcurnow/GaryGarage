using System;

namespace GaryGarage
{
    public class Ram : Vehicle
    {
        public double FuelCapacity { get; set; }
        public void RefuelTank()
        {
            // nothing yet
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