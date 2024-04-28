using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turingTest
{
    class Program
    {
        public static void Main()
        {
            int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int sum = SumDiagonals(matrix);
            Console.WriteLine(sum);
            Console.ReadKey();
        }

        public static int SumDiagonals(int[,] matrix)
        {
            int primaryDiagonalSum = 0;
            int secondaryDiagonalSum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                primaryDiagonalSum += matrix[i, i];
                secondaryDiagonalSum += matrix[i, matrix.GetLength(0) - i - 1];
            }
            return primaryDiagonalSum + secondaryDiagonalSum;
        }
    }
}
