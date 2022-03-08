using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Pyramid
    {
        int numOfAsterixs = 1;
        int totalRows;

        public Pyramid(int nRows)
        {
            int totalWhiteSpaces = nRows + 1;
            totalRows = nRows;


            while (totalRows > 0)
            {
                for (int i = totalWhiteSpaces; i > 0; i -= 1)
                {
                    Console.Write(" ");
                }


                PrintAsterix(numOfAsterixs);
                Console.WriteLine();
                numOfAsterixs += 2;
                totalRows -= 1;
                totalWhiteSpaces -= 1;
            }
        }

        private void PrintAsterix(int n)
        {
            while (n > 0)
            {
                if (n == 1 || n == numOfAsterixs || totalRows == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.Write("*");
                Console.ForegroundColor = ConsoleColor.White;
                n -= 1;
            }
        }
    }
}
