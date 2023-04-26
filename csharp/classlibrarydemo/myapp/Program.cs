using mylibrary;
using System.Runtime.CompilerServices;

namespace myapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your choice");
            int choice = Convert.ToInt16(Console.ReadLine());
            calculator calc = new calculator();
            switch (choice)
            {
                case 1:
                    Console.WriteLine(calc.add(a, b));
                    break;
                case 2:
                    Console.WriteLine(calc.sub(a, b));
                    break;
                case 3:
                    Console.WriteLine(calc.mul(a, b));
                    break;
                case 4:
                    Console.WriteLine(calc.div(a, b));
                    break;
                default:
                    Console.WriteLine("enter the correct choice");
                    break;
            }
            Console.ReadKey();
        }
    }
}