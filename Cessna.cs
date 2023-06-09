namespace Garage
{
    public class Cessna : Vehicle, IgasVehicle // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }
        public int CurrentTankPercentage { get; set;} = 65;
        public void RefuelTank()
        {
            // method definition omitted
            CurrentTankPercentage = 100;
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna flashes by you like a hurricane. Vrooooom!");
        }
        public override void Stop()
        {
            Console.WriteLine("The Cessna pulls the E-brake!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The Cessna takes a hard lean to the {direction}");
        }
    }
}