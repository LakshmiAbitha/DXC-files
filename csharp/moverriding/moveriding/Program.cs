namespace moveriding
{
    class class1
    {
        public virtual void print(int x,int y)
        {
            Console.WriteLine(x+y);
        }
    }
    class class2 : class1
    {
        public override void print(int x,int y)
        {
            Console.WriteLine(x*y);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            class2 obj=new class2();
            obj.print(10,2);
        }
    }
}