using System;

class Program
{
    static void Main(string[] args)
    {
        const int N = 3;
        int[,] A = new int[N, N] { { 1, -2, 3 }, { 4, -5, 6 }, { 7, -8, 9 } };

        // Заменяем отрицательные элементы на 0 и положительные на 1
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (A[i, j] < 0)
                {
                    A[i, j] = 0;
                }
                else
                {
                    A[i, j] = 1;
                }
            }
        }

        // Выводим матрицу A на экран
        Console.WriteLine("Матрица A:");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write("{0} ", A[i, j]);
            }
            Console.WriteLine();
        }

        // Выводим нижнюю треугольную матрицу
        Console.WriteLine("Нижняя треугольная матрица:");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (i >= j)
                {
                    Console.Write("{0} ", A[i, j]);
                }
                else
                {
                    Console.Write("  ");
                }
            }
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}