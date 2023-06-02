namespace Garage
{
    public class Zero : Vehicle // Electric motorcycle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
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