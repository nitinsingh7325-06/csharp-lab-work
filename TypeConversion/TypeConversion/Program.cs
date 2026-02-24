using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            float a;
            int b = 27;
            a = b;
            Console.WriteLine(a);

            float n = 2000.0F;
            int m;
            n = (int)n;
            Console.WriteLine(n);
        }
    }
}