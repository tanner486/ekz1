using System;

class Program
{
    static void Main(string[] args)
    {
        string str = "The quick brown fox jumps over the lazy dog";
        char ch = 'x';
        int count = CountWordsEndingWith(str, ch);
        Console.WriteLine($"Количество слов, оканчивающихся на символ {ch}: {count}");
    }

    static int CountWordsEndingWith(string str, char ch)
    {
        int count = 0;
        string[] words = str.Split(' ');

        foreach (string word in words)
        {
            if (word[word.Length - 1] == ch)
            {
                count++;
            }
        }

        return count;
    }
}