namespace runtimepoly
{
    class person
    {
        public virtual void show()
        {
            Console.WriteLine("This is show method of person");
        }
    }
    class student : person
    {
        public override void show()
        {
            Console.WriteLine("This is show method of student");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            person p=new student();
            p.show();
        }
    }
}