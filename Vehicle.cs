namespace Garage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine("Vrooom!");
        }
        public virtual void Turn(string direction)
        {
            Console.WriteLine("");
        }
        public virtual void Stop()
        {
            Console.WriteLine("");
        }
    }
    public interface IelectricVehicle
    {
        void ChargeBattery();
        int CurrentChargePercentage {get;}
    }
    public interface IgasVehicle
    {
        void RefuelTank();
        int CurrentTankPercentage {get;}
    }
}