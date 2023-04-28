using System.Collections;
namespace stackdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack s= new Stack();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push(4);
            s.Push(5);
            foreach(var i in s) 
            { 
                Console.WriteLine(i);
            }
            Console.WriteLine("After removing");
            s.Pop();
            s.Pop();
            foreach (var i in s)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(s.Contains(1));
            Console.WriteLine(s.Peek());
            Console.WriteLine("After clear");
            s.Clear();
            foreach (var i in s)
            {
                Console.WriteLine(i);
            }

        }
    }
}