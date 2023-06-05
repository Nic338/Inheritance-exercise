namespace Garage
{
    public class Zero : Vehicle , IelectricVehicle// Electric motorcycle
    {
        public double BatteryKWh { get; set; }
        public int CurrentChargePercentage {get; set;} = 75;
        public void ChargeBattery()
        {
            // method definition omitted
            CurrentChargePercentage = 100;
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero zips by you. Kachow!");
        }
        public override void Stop()
        {
            Console.WriteLine("The Zero screeches to a halt!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The Zero turns {direction}");
        }
    }
}