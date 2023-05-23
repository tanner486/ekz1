using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "text.txt"; // путь к файлу с текстом
        string[] separators = { " ", ",", ".", "!", "?", ";", ":", "-", "(", ")", "\n", "\r" }; // разделители для разбиения текста на слова
        string[] text = File.ReadAllText(filePath).ToLower().Split(separators, StringSplitOptions.RemoveEmptyEntries); // считываем текст из файла и разбиваем на слова, приводим к нижнему регистру

        int[] wordsCount = new int[11]; // массив для хранения количества слов заданной длины

        // создаем массивы для хранения слов заданной длины
        var words1 = new System.Collections.Generic.List<string>();
        var words2 = new System.Collections.Generic.List<string>();
        var words3 = new System.Collections.Generic.List<string>();
        var words4 = new System.Collections.Generic.List<string>();
        var words5 = new System.Collections.Generic.List<string>();
        var words6 = new System.Collections.Generic.List<string>();
        var words7 = new System.Collections.Generic.List<string>();
        var words8 = new System.Collections.Generic.List<string>();
        var words9 = new System.Collections.Generic.List<string>();
        var words10 = new System.Collections.Generic.List<string>();
        var wordsMoreThan10 = new System.Collections.Generic.List<string>();

        // перебираем все слова и добавляем их в соответствующие массивы
        foreach (string word in text)
        {
            int length = word.Length;
            if (length > 10) // больше 10 символов
            {
                wordsMoreThan10.Add(word);
                wordsCount[10]++;
            }
            else if (length == 1) // ровно 1 символ
            {
                words1.Add(word);
                wordsCount[1]++;
            }
            else // от 2 до 10 символов
            {
                switch (length)
                {
                    case 2:
                        words2.Add(word);
                        break;
                    case 3:
                        words3.Add(word);
                        break;
                    case 4:
                        words4.Add(word);
                        break;
                    case 5:
                        words5.Add(word);
                        break;
                    case 6:
                        words6.Add(word);
                        break;
                    case 7:
                        words7.Add(word);
                        break;
                    case 8:
                        words8.Add(word);
                        break;
                    case 9:
                        words9.Add(word);
                        break;
                    case 10:
                        words10.Add(word);
                        break;
                }
                wordsCount[length]++;
            }
        }

        // выводим слова в порядке возрастания их длины
        Console.WriteLine("Слова длиной 1 символ:");
        words1.Sort();
        Console.WriteLine(string.Join(" ", words1));

        Console.WriteLine("Слова длиной 2 символа:");
        words2.Sort();
        Console.WriteLine(string.Join(" ", words2));

        Console.WriteLine("Слова длиной 3 символа:");
        words3.Sort();
        Console.WriteLine(string.Join(" ", words3));

        Console.WriteLine("Слова длиной 4 символа:");
        words4.Sort();
        Console.WriteLine(string.Join("", words4));

        Console.WriteLine("Слова длиной 5 символов:");
        words5.Sort();
        Console.WriteLine(string.Join(" ", words5));

        Console.WriteLine("Слова длиной 6 символов:");
        words6.Sort();
        Console.WriteLine(string.Join(" ", words6));

        Console.WriteLine("Слова длиной 7 символов:");
        words7.Sort();
        Console.WriteLine(string.Join(" ", words7));

        Console.WriteLine("Слова длиной 8 символов:");
        words8.Sort();
        Console.WriteLine(string.Join(" ", words8));

        Console.WriteLine("Слова длиной 9 символов:");
        words9.Sort();
        Console.WriteLine(string.Join(" ", words9));

        Console.WriteLine("Слова длиной 10 символов:");
        words10.Sort();
        Console.WriteLine(string.Join(" ", words10));

        Console.WriteLine("Слова длиннее 10 символов:");
        wordsMoreThan10.Sort();
        Console.WriteLine(string.Join(" ", wordsMoreThan10));

        // выводим количество слов заданной длины
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Количество слов длиной {i} символов: {wordsCount[i]}");
        }
        Console.WriteLine($"Количество слов длиной больше 10 символов: {wordsCount[10]}");

        Console.ReadLine();
    }
}