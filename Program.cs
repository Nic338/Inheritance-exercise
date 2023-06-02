namespace Garage
{
    class Program
    {
        static void Main(string[] args) 
        {
            Zero fxs = new Zero()
            {
                MainColor = "red",
                MaximumOccupancy = 2,
                BatteryKWh = 35
            };
            Tesla modelS = new Tesla()
            {
                MainColor = "black",
                MaximumOccupancy = 5,
                BatteryKWh = 38
            };
            Cessna mx410 = new Cessna()
            {
                MainColor = "white",
                MaximumOccupancy = 10,
                FuelCapacity = 1236
            };
            Ram r1500 = new Ram()
            {
                MainColor = "forest green",
                MaximumOccupancy = 5,
                FuelCapacity = 33
            };

            fxs.Drive();
            fxs.Turn("left");
            fxs.Stop();
            Console.WriteLine();
            modelS.Drive();
            modelS.Turn("right");
            modelS.Stop();
            Console.WriteLine();
            mx410.Drive();
            mx410.Turn("right");
            mx410.Stop();
            Console.WriteLine();
            r1500.Drive();
            r1500.Turn("left");
            r1500.Stop();
        }
    }
}
