using System;

namespace GaryGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            Tesla modelS = new Tesla();
            modelS.MainColor = "white";

            Ram truck = new Ram();
            truck.MainColor = "black";

            Cessna plane = new Cessna();
            plane.MainColor = "sky blue";

            modelS.Drive();
            modelS.Turn("left");
            modelS.Stop();
            truck.Drive();
            truck.Turn("Right");
            truck.Stop();
            plane.Drive();
            plane.Turn("further up");
            plane.Stop();
        }
    }
}