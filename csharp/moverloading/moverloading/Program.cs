namespace moverloading
{
    class demo
    {
        public void add(int a,int b)
        {
            Console.WriteLine(a + b);
        }
        public void add(int a, int b,int c)
        {
            Console.WriteLine(a + b+c);
        }
        public void add(string a,string b)
        {
            Console.WriteLine(a + b);
        }
        public void add(float a, float b)
        {
            Console.WriteLine(a + b);
        }
        public void add(float a, int b)
        {
            Console.WriteLine(a + b);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            demo d = new demo();
            d.add(1,2);
            d.add(10, 20, 30);
            d.add("Hi", " Welcome");
            d.add(2.5f, 3.5f);
            d.add(2.5f, 20);
        }
    }
}