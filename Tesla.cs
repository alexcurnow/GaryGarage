using System;

namespace GaryGarage
{
    public class Tesla : Vehicle, IElectricVehicle
    {
        public double BatteryKWh { get; set; }
        public int CurrentChargePercentage { get; set; } = 75;

        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
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