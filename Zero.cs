namespace GaryGarage
{
    public class Zero : Vehicle, IElectricVehicle // Electric motorcycle
    {
        public double BatteryKWh { get; set; }
        public int CurrentChargePercentage { get; set; } = 50;

        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }
    }
}