namespace Garage
{
    public class Ram : Vehicle, IgasVehicle // Gas powered truck
    {
        public double FuelCapacity { get; set; }
        public int CurrentTankPercentage {get; set;} = 25;
        public void RefuelTank()
        {
            // method definition omitted
            CurrentTankPercentage = 100;
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram barrels past. Rrrrrrrrumble!");
        }
        public override void Stop()
        {
            Console.WriteLine("The Ram comes to a screeching halt");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The Ram flies over the enbankment on the {direction} side of the road");
        }
    
    }
}