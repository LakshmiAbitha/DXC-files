using System.Collections;
namespace hashtabledemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(6, "six");
            ht.Add(3, "Three");
            ht.Add(4, "Four");
            ht.Add(1, "One");
            ht.Add(2, "Two");
            ht.Add(5, "Five");
            foreach(var item in ht.Values)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("After removing");
            ht.Remove(6);
            foreach (var item in ht.Values)
            {
                Console.WriteLine(item);
            }
        }
    }
}