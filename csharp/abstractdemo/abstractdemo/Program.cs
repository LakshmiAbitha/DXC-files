namespace abstractdemo
{
    abstract class class1
    {
        public abstract void add(int a,int b);
        public abstract void sub(int a,int b);
    }
    class class2 : class1
    {
        public override void add(int a,int b)
        {
            Console.WriteLine(a + b);
        }
        public override void sub(int a, int b)
        {
            Console.WriteLine(a -b);
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            class2 obj= new class2();
            obj.add(10,20);
            obj.sub(20,10);
        }
    }
}