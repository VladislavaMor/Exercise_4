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
            int[,] matrix = new int[n, m];
            int sum = 0;
            for (int i = 0; i < n; i++)
            { 
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = random.Next();
                    Write(matrix[i, j] + " ");
                    sum += matrix[i, j];
                }
                WriteLine();
            }
            WriteLine("Сумма элементов матрицы: " + sum);
        }
    }
}