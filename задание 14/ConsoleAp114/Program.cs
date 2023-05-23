using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 1, -2, 3, -4, 5, -6, 7, -8, 9, -10, 11, -12, 13, -14, 15, -16, 17, -18, 19, -20 };

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                array[i] = array[i] * array[i];
            }
        }

        Console.WriteLine("Измененная последовательность:");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.ReadLine();
    }
}