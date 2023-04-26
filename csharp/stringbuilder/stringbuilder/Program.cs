namespace stringbuilder
{
    using System.Text;
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("welcome to csharp");
            Console.WriteLine(sb);
            sb.Append(" hello");
            sb.Insert(10, " new");
            Console.WriteLine(sb);
            Console.WriteLine(sb.Length);
            Console.WriteLine(sb.Capacity);
        }
    }
}