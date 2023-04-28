namespace interfacedemo
{
    interface Myinterface
    {
        void add(int a, int b);
        void sub(int a, int b);
        void multiply(int a, int b);
    }
    interface Myinterface2:Myinterface
    {
        void cube(int a);
    }
    class demo
    {
        public void show()
        {
            Console.WriteLine("this is show method");
        }
    }
    class class1:demo,Myinterface2{ 
        public void add(int a, int b)
        {
            Console.WriteLine(a+b);
        }
        public void sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        public void multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        public void cube(int a)
        {
            Console.WriteLine(a * a * a);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            class1 obj= new class1();
            obj.add(1,2);
            obj.sub(3,1);
            obj.multiply(3,4);
            obj.cube(3);
            obj.show();
        }
    }
}