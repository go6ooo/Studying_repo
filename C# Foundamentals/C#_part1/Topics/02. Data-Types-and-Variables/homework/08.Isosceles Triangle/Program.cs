

namespace _08.Isosceles_Triangle
{
    using System;

    class Program
    {
        static void Main()
        {

            char[,] matrix = new char[7, 7];
            
            char sigh = '\u00a9';
            

            for (int row = 0, col = 3; row < 7; row += 2, col++)
            {
                matrix[row, col] = sigh;
            }
            for (int row = 0, col = 3; row < 7; row += 2, col--)
            {
                matrix[row, col] = sigh;
            }

            for (int row = 6, col = 0; col < 5 ; col+=2)
            {
                matrix[row, col] = sigh;
            }


            for (int row = 0; row < 7; row++)
            {
                for (int col = 0; col < 7; col++)
                {
                    Console.Write(matrix[row, col]);

                }
                Console.WriteLine();
            }


        }
    }
}


//   ©
//
//  © ©
//
// ©   ©
//
//© © © ©