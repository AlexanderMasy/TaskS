using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryForTasks
{
    public static class ClassForTask1
    {
        public static int[,] FillingRandomValuesArray(int row, int col)
        {
            int[,] arr = new int [row, col];
            for (int i = 0; i < row; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    Random rnd = new Random();
                    arr[i, j] = rnd.Next(1, 10);
                }
            }
            return arr;
        }

        public static void OutputValuesArray(int [,] arr)
        {
            int rows = arr.GetUpperBound(0) + 1;
            int columns = arr.Length / rows;
            Console.WriteLine("____________________________");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(Convert.ToString(arr[i, j]) + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("___________________________");
        }

        public static string Logic(int [,] arr)
        {
            int aboveCount = 0;
            int underCount = 0;
            int numberRows = arr.GetUpperBound(0) + 1;
            int numberColumns = arr.Length / numberRows;

            for (int row = 0; row < numberRows; row++)
            {
                for(int column = 0; column < numberColumns; column++)
                {
                    if(row>column && (arr[row, column] % 2 == 0))
                    {
                        underCount++;
                    }
                    if (column > row && (arr[row, column] % 2 == 0))
                    {
                        aboveCount++;
                    }
                }
            }
            string strResult = $"Вверх {aboveCount};\nВнизу {underCount}";
            return strResult;
        }
    }
}
