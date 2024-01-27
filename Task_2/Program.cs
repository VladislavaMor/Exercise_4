using System;
using static System.Console;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Введите количество строк:");
            int n = int.Parse(ReadLine());
            Write("Введите количество столбцов:");
            int m = int.Parse(ReadLine());
            Random random = new Random();
           
            int[,] matrix_1 = new int[n, m];
            WriteLine("Первая матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix_1[i, j] = random.Next(100);
                    Write(matrix_1[i, j] + " ");
                }
                WriteLine();
            }

            int[,] matrix_2 = new int[n, m];
            WriteLine("Вторая матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix_2[i, j] = random.Next(100);
                    Write(matrix_2[i, j] + " ");
                }
                WriteLine();
            }

            WriteLine("----------------------------------------------------------");
            WriteLine("Сумма матриц:");
            int[,] matrix_sum = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix_sum[i, j] = matrix_1[i, j] + matrix_2[i, j];
                    Write(matrix_sum[i, j] + " ");
                }
                WriteLine();
            }
        }
    }
}
