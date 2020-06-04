using System;

namespace GaryGarage
{
    public class Tesla : Vehicle
    {
        public double BatteryKWh { get; set; }
        public void ChargeBattery()
        {
            // nothing yet...
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla whizzes past you!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The Telsa quiety takes a {direction} turn.");
        }

    }
}