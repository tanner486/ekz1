using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите размер массива: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        Console.WriteLine("Введите элементы массива:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        bool isAlternating = true; // переменная для хранения результата проверки
        int index = -1; // переменная для хранения индекса первого нарушающего элемента

        for (int i = 1; i < n; i++)
        {
            if ((arr[i] % 2 == 0 && arr[i - 1] % 2 != 0) || (arr[i] % 2 != 0 && arr[i - 1] % 2 == 0))
            {
                // элементы чередуются
                isAlternating = true;
            }
            else
            {
                // элементы не чередуются, сохраняем индекс нарушающего элемента и выходим из цикла
                isAlternating = false;
                index = i;
                break;
            }
        }

        if (isAlternating)
        {
            Console.WriteLine("Чередуются, 0");
        }
        else
        {
            Console.WriteLine("Порядковый номер элемента нарушающего закономерность: "+index);
        }
    }
}