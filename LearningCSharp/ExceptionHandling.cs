using System;

namespace CustomException
{
    public class DivideByOddNumberException : ApplicationException
    {
        public override string Message
        {
            get
            {
                return "Cannot divide by odd numeral.";
            }
        }
    }

    public class ExceptionHandling
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter 1st number: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter 2nd number: ");
                int y = Convert.ToInt32(Console.ReadLine());
                if (y % 2 != 0)
                {
                    throw new DivideByOddNumberException();
                }
                int ans = x / y;
                Console.WriteLine("The answer is: " + ans);
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            finally
            {
                Console.WriteLine("Program execution finished.");
            }
        }
    }
}
