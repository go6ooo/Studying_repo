

namespace _09.Exchange_Variable_Values
{
    using System;
    class Program
    {
        static void Main()
        {
            int a = 5;
            int b = 10;

            int c = a;

            a = b;
            b = c;
            Console.WriteLine($"{a} , {b}");
        }
    }
}
