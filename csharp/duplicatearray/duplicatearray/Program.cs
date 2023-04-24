namespace duplicatearray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr ={ 1,2,3,1,2,3,4,5,6,7};
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("The number of duplicate values:"+count);
        }
    }
}