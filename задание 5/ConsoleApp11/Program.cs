using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите символ C:");
        char c = Console.ReadKey().KeyChar;
        Console.WriteLine("\nВведите строку S:");
        string s = Console.ReadLine();
        Console.WriteLine("Введите строку S1:");
        string s1 = Console.ReadLine();

        string result = "";

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == c)
            {
                result += s1;
            }

            result += s[i];
        }

        Console.WriteLine("Результат: {0}", result);
    }
}