namespace arraylargest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num1 = new int[] { 7, 4, 5, 6, 8, 2, 3, 1 };
            int lar = num1[0];
            for (int i = 0; i < num1.Length; i++)
            {
                if (num1[i] > lar)
                {
                    lar = num1[i];
                }
            }
            Console.WriteLine($" Largest number is {lar}");
        } 
    }
}