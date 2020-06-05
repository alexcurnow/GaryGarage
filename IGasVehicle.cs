namespace GaryGarage
{
    public interface IGasVehicle
    {
        int CurrentTankPercentage { get; set; }
        void RefuelTank();
    }
}