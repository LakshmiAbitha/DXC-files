using System.Collections;
namespace queuesdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue q= new Queue();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4);
            q.Enqueue(5);
            foreach (var item in q) 
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("After removing");
            q.Dequeue();
            q.Dequeue();
            foreach (var item in q)
            {
                Console.WriteLine(item);
                Console.WriteLine(item.Equals(5));
            }
            Console.WriteLine(q.Peek());
        }
    }
}