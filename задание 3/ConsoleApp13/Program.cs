using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите размерность матрицы: ");
        int n = int.Parse(Console.ReadLine());

        double[,] A = new double[n, n];

        // Заполнение матрицы случайными значениями
        Random random = new Random();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                A[i, j] = random.NextDouble();
            }
        }

        // Вывод исходной матрицы на экран
        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0:0.00} ", A[i, j]);
            }
            Console.WriteLine();
        }

        // Сортировка элементов, расположенных под главной диагональю методом "пузырька"
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n - 1; j++)
            {
                if (j < i)
                {
                    continue;
                }
                for (int k = j + 1; k < n; k++)
                {
                    if (k < i)
                    {
                        continue;
                    }
                    if (A[j, i] > A[k, i])
                    {
                        double temp = A[j, i];
                        A[j, i] = A[k, i];
                        A[k, i] = temp;
                    }
                }
            }
        }

        // Вывод отсортированной матрицы на экран
        Console.WriteLine("Отсортированная матрица:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0:0.00} ", A[i, j]);
            }
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}