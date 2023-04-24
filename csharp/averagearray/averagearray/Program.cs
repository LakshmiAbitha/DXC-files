namespace averagearray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int avg = 0;
            int sum = 0;
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = Convert.ToInt16(Console.ReadLine());
                sum += arr[i];
            }
            avg = sum / arr.Length;
            Console.WriteLine($"The average of elements is {avg}");
        }
    }
}