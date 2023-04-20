namespace switchcase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first no");
            int n1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("enter second no");
            int n2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("enter opeartor");
            char ch = Convert.ToChar(Console.ReadLine());
            switch(ch)
            {
                case '+':
                    {
                        Console.WriteLine(n1+n2);
                        break;
                    }
                case '-':
                    {
                        Console.WriteLine(n1-n2);
                        break;
                    }
                case '*':
                    {
                        Console.WriteLine(n1*n2);
                        break;
                    }
                case '/':
                    {
                        Console.WriteLine(n1/n2);
                        break;
                    }
                case '%':
                    {
                        Console.WriteLine(n1%n2);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Please enter correct operator");
                        break;
                    }
            }
        }
    }
}