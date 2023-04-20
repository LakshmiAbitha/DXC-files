namespace Studentdetails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the student id");
            int id = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the student name");
            string name =Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the student age");
            int age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the  first marks");
            double m1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the  second marks");
            double m2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the  third marks");
            double m3 = Convert.ToInt16(Console.ReadLine());
            double total =(m1 + m2 + m3);
            double per = (total / 300) * 100;
            Console.WriteLine("your Total marks are" + total);
            Console.WriteLine(" your percentage is" + per);
            if (per > 50)
            {
                Console.WriteLine("result is pass");
                if (per >= 90 && per <= 100)
                {
                    Console.WriteLine(" your grade is A");
                }
                else if (per >= 80 && per <= 89)
                {
                    Console.WriteLine(" your grade is B");
                }
                else if (per >= 60 && per <= 79)
                {
                    Console.WriteLine(" your grade is c");
                }
                else if (per >= 50 && per <= 59)
                {
                    Console.WriteLine(" your grade is D");
                }
            }
            else
            {
                Console.WriteLine("Result is fail");
                Console.WriteLine("Your grade is E");
            }
               
        }
    }
}