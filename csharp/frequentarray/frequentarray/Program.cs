using System.Globalization;

namespace frequentarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 7, 7, 7, 7, 8, 8, 8, 5, 5, 5, 5, 6, 6, 6, 6 };
            int fre = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > fre)
                {
                    fre = arr[i];
                }
            }
            int[] j = new int[fre + 1];
            for (int i = 0; i <= fre; i++)
            {
                j[i] = 0;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                j[arr[i]]++;
            }
            int k = 0;
            for (int i = 0; i <= fre; i++)
            {
                if (j[i] > k)
                {
                    k = j[i];
                }
            }
            Console.WriteLine("Elements that occur most frequently are:");
            for (int i = 0; i <= fre; i++)
            {
                if (j[i] == k)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}