

namespace Age
{
    using System;

    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int inputYear = int.Parse(input.Substring(6, 4));
            int inputMonth = int.Parse(input.Substring(0, 2));
            DateTime currentDate = DateTime.Today;
            int currentAge = currentDate.Year - inputYear;

            if (inputMonth > currentDate.Month)
            {
                currentAge-= 1;
            }
            Console.WriteLine(currentAge);
            Console.WriteLine(currentAge + 10);

        }
    }
}
