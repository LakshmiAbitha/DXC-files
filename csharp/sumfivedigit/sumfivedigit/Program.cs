namespace sumfivedigit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the digit");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int sum = 0, x;
            while (n1 > 0)
            {
                x = n1 % 10;
                sum = sum + x;
                n1 = n1 / 10;
            }
            Console.WriteLine($"the sum of digits is {sum}");

        }
    }
}