namespace rectange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of rectangle:");
            double length= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the breadth of rectangle:");
            double breadth = Convert.ToDouble(Console.ReadLine());
            double perimeter = 2 * (length + breadth);
            Console.WriteLine(perimeter);
        }
    }
}