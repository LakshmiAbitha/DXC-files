using System.Collections;
namespace arraylist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add("Hello");
            list.Add("Welcome");
            list.Add(true);
            list.Add(2.5f);
            Console.WriteLine(list.Count);
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("After insertion");
            list.Insert(0, "Csharp");
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("after reverse");
            list.Reverse();
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
            list.Remove("Hello");
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }

        }
    }
}