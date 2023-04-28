namespace genericdemo
{
    class demo<A>
    {
        A num1 ;
        public void setvalue(A x)
        {
            num1 = x;
        }
        public A getvalue()
        {
            return num1;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            demo<int> d = new demo<int>();
            d.setvalue(30);
            Console.WriteLine(d.getvalue());
            demo<string> d1= new demo<string>();
            d1.setvalue("welcome");
            Console.WriteLine(d1.getvalue());
        }
    }
}