

namespace _13.Comparing_Floats
{
    using System;
    class Program
    {
        static void Main()
        {
            double eps = 0.000001;
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double tempResult = Math.Abs(a - b);

            if (tempResult < eps)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

        }
    }
}
