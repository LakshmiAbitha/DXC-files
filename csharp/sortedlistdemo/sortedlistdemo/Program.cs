using System.Collections;
namespace sortedlistdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList st= new SortedList();
            st.Add(1, "one");
            st.Add(3, "three");
            st.Add(2, "two");
            st.Add(5, "five");
            st.Add(4, "four");
            Console.WriteLine(st[3]);
            Console.WriteLine(st.GetKey(4));
            foreach(var item in st.Keys)
            {
                Console.WriteLine($"Key:{item}, values:{st[item]}");
            }
            foreach (var item in st.Values)
            {
                Console.WriteLine(item);

            }
        }
    }
}