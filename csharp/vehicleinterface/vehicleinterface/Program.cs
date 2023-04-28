namespace vehicleinterface
{
    interface Ivehiculo
    {
        void Drive();
        bool Refuel(int amount);
    }
    class Car : Ivehiculo
    {
        private int gasoline;
        public Car(int initialGasoline)
        {
            gasoline = initialGasoline;
        }
        public void Drive()
        {
            if (gasoline> 0)
            {
                Console.WriteLine("The car is driving");
            }
        }
        public bool Refuel(int amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("The amount is invalid");
                return false;
            }
            gasoline += amount;
            Console.WriteLine("Gasoline is refuled current gasoline level:" + gasoline);
            return true;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount of gasoline to refule");
            int amount=Convert.ToInt32(Console.ReadLine());
            Car obj = new Car(0);
            obj.Refuel(amount);
            obj.Drive();
        }
    }
}
