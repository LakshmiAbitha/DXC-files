namespace iterativecelcius
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit,celcius;
            char ch;
            do
            {
                Console.WriteLine("enter the celcius");
                celcius = Convert.ToDouble(Console.ReadLine());
                fahrenheit = (celcius * 9) / 5 + 32;
                Console.WriteLine($"Temperature {celcius} : {fahrenheit }");
                Console.WriteLine("Do you wish to continue(y/n)?");
                ch=Convert.ToChar(Console.ReadLine());          
            } while (ch == 'y');
            
        }
    }
}