namespace Garage
{
    class Program
    {
        static void Main (string[] args)
        {
            Zero fxs = new Zero();
            Zero fx = new Zero();
            Tesla modelS = new Tesla();

            List<IelectricVehicle> electricVehicles = new List<IelectricVehicle>() {
                fx, fxs, modelS
            };

            Console.WriteLine("Electric Vehicles");
            foreach(IelectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            foreach(IelectricVehicle ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            foreach(IelectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            /***********************************************/

            Ram ram = new Ram ();
            Cessna cessna150 = new Cessna ();

            List<IgasVehicle> gasVehicles = new List<IgasVehicle>() {
                ram, cessna150
            };

            Console.WriteLine("Gas Vehicles");
            foreach(IgasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }

            foreach(IgasVehicle gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }

            foreach(IgasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }
        }
    }
}