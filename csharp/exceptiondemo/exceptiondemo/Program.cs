namespace exceptiondemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c = 0;
            try
            {
                Console.WriteLine("Enter First number");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number");
                b = Convert.ToInt32(Console.ReadLine());
                if (a < b)
                {
                    throw new IncorrectValueException("value of first number cannot less than second number");
                }
                c = a / b;
            }
            catch(DivideByZeroException) 
            {
                Console.WriteLine("You cannot divide a number by zero");
            }
            catch (FormatException)
            {
                Console.WriteLine("Only numbers are allowed");
            }
            catch (IncorrectValueException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong");
            }
            finally
            {
                Console.WriteLine($"The result is{c}");
                Console.WriteLine("Porgram end");
            }
        }
    }
}