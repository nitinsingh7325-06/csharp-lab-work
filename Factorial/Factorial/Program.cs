using System;

namespace Factorial
{
    class FactorialProgram
    {
        static void Main()
        {
            int num;
            int fact = 1;

            Console.WriteLine("Enter a number: ");
            num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;
            }

            Console.WriteLine("Factorial of is: " + fact);
        }
    }
}