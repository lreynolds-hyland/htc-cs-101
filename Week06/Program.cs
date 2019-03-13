using System;

namespace Week06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(factorial(userInput));
        }

        public static int factorial(int number)
        {
            int total = 1;
            while (number > 0)
            {
                total *= number;
                number--;
            }
            return total;
        }
    }
}
