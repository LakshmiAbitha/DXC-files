namespace vowels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the alphabet");
            char ch = Convert.ToChar(Console.ReadLine());
            if (ch =='a'||ch =='A'||ch =='e'||ch =='E'||ch =='i'||ch =='I'||ch =='o'||ch =='O'||ch =='u'||ch =='U')
            {
                Console.WriteLine("It is vowel");
            }
            else
            {
                Console.WriteLine("it is not vowel");
            }
        }
    }
}