namespace Decisionmaking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int num1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int num2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Third number");
            int num3 = Convert.ToInt16(Console.ReadLine());
            if(num1>num2 && num1 > num3)
            {
                Console.WriteLine("First is greater");
            }
            else if (num2 > num3)
            {
                Console.WriteLine("Second is greater");
            }
            else
            {
                Console.WriteLine("third is greater");
            }

        }
    }
}