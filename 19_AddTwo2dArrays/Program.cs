using System;

namespace AddTwo2dArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            const int ROW_COUNT = 4;
            const int COLUMN_COUNT = 5;

            int[,] array1 = new int[ROW_COUNT, COLUMN_COUNT]
            {
                {1, 2, 3, 4, 5},
                {-7, -11, 45, 2, 8},
                {0, 0, 10, 30, 100},
                {-99, -50, 18, 44, 97}
            };

            int[,] array2 = new int[ROW_COUNT, COLUMN_COUNT]
            {
                {7, 82, 30, -5, -8},
                {-11, 24, 3, 90, -5},
                {6, 88, 10, -2, 34},
                {5, 3, 12, -12, 1}
            };

            int[,] sumArray = new int[ROW_COUNT, COLUMN_COUNT];

            for (int i = 0; i < ROW_COUNT; ++i)
            {
                for (int j = 0; j < COLUMN_COUNT; ++j)
                {
                    sumArray[i, j] = array1[i, j] + array2[i, j];
                }
            }

            // 출력
            for (int i = 0; i < ROW_COUNT; ++i)
            {
                for (int j = 0; j < COLUMN_COUNT; ++j)
                {
                    Console.Write($"{sumArray[i, j], 11}");
                }

                Console.WriteLine();
            }
        }
    }
}