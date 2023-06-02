namespace Garage
{
    public class Tesla : Vehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla blazes by you. Wooooosh!");
        }
        public override void Stop()
        {
            Console.WriteLine("The Tesla stops on a dime.");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The Tesla overtakes the vehicle in front and maneuvers to the {direction}");
        }
    }
}