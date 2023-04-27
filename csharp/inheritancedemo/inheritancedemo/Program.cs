namespace inheritancedemo
{
    class vehicle
    {
        public vehicle()
        {
            Console.WriteLine("This is vehicle class");
        }
        public vehicle(string name)
        {
            Console.WriteLine($"This is vehicle of{name}");
        }
        public void show()
        {
            Console.WriteLine("this is show method of vehicle");
        }

        public void details()
        {
            Console.WriteLine("It is having details of vehicle");
        }
    }
    class car:vehicle
    {
        public car():base("bmw")
        {
            Console.WriteLine("This is car class");
        }
        public void swift()
        {
            Console.WriteLine("This is swift car");
        }
        public void honk()
        {
            Console.WriteLine("This is honk car");
        }
        public new void show()
        {
            Console.WriteLine("this is show method of car");
        }

    }
    class bike : car
    {
        public bike()
        {
            Console.WriteLine("This is bike class");
        }
        public void fz()
        {
            Console.WriteLine("This is fz bike");
        }
        public void ktm()
        {
            Console.WriteLine("This is ktm bike");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            bike c = new bike();
            c.details();
            c.swift();
            c.honk();
            c.fz();
            c.ktm();
            c.show();
        }
    }
}