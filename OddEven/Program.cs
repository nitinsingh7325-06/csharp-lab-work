using System;

namespace OddEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("The number is Even");
            }
            else
            {
                Console.WriteLine("The number is Odd");
            }
        }
    }
}