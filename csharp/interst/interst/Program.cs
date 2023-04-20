namespace interst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pamount = 23000;
            double rate = 12.75;
            Console.WriteLine("Enter the time period");
            int time = Convert.ToInt16(Console.ReadLine());
            double sinterst;
            sinterst = Convert.ToDouble((pamount * rate * time) / 100);
            Console.WriteLine(sinterst);
        }
    }
}