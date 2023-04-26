namespace staticdemo
{
    class staticdemo
    {
        static int n = 0;
        public void increment()
        {
            n++;
            Console.WriteLine(n);
        }
        public static void show()
        {
            Console.WriteLine("this is show method");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            staticdemo d1 = new staticdemo();
            staticdemo d2 = new staticdemo();
            staticdemo d3 = new staticdemo();
            d1.increment();
            d2.increment();
            d3.increment();
            staticdemo.show();
        }
    }
}