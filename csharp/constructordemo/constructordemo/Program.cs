namespace constructordemo
{
    class Constructodemo
    {
        public Constructodemo()
        {
            Console.WriteLine("This is a constructor");
        }
        public Constructodemo(int a)
        {
            Console.WriteLine("This is another constructor");
        }
        public void show()
        {
            Console.WriteLine("This is a show method");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Constructodemo d = new Constructodemo();
            Constructodemo d2 = new Constructodemo(10);
            d.show();
        }
    }
}