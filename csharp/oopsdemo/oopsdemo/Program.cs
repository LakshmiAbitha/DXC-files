using System;

namespace oopsdemo
{
    class Calculator
    {
        public void show()
        {
            Console.WriteLine("this is show method");
        }
        public void sayhello(String name)
        {
            Console.WriteLine($"hello {name}");
        }
        public void sum(int a,int b)
        {
            Console.WriteLine(a + b);
        }
        public void sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        public void mul(int a, int b)
        {
            Console.WriteLine(a*b);
        }
        public void div(int a, int b)
        {
            Console.WriteLine(a / b);
        }
        public int cube(int x)
        {
            return x * x * x;
        }
        public void add(int a, int b=0,int c=0)
        {
            Console.WriteLine(a + b + c);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            cal.show();
            cal.sayhello("ram");
            cal.sum(20, 30);
            cal.sub(30, 20);
            cal.mul(2, 2);
            cal.div(6, 3);
            int r=cal.cube(2);
            Console.WriteLine(r);
            cal.add(10);
            cal.add(10, 20);
            cal.add(10, 10, 20);
        }
    }
}