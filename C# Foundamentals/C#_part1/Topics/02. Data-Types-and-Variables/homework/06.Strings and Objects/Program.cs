
namespace _06.Strings_and_Objects
{
    using System;

    class Program
    {
        static void Main()
        {
            string str1 = "Hello";
            string str2 = "World";
            object obj = (object)(str1 + " " + str2);
            Console.WriteLine(obj);
        }
    }
}
