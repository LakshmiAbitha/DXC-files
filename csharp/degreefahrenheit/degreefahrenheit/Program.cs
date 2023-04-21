namespace degreefahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celcius = 0;
            int no=0;
            Console.WriteLine("Sr.no     celcius  fahrenheit");
            while (celcius<=90)
            {
                no++;
                double fahrenheit = (celcius * 1.8) + 32;
                Console.WriteLine($"{no}         {celcius}       {fahrenheit}");
                celcius += 10;
            }
        }
    }
}