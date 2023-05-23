using System;

struct Medicine
{
    public string Name;
    public string Type;
    public DateTime ManufacturingDate;
    public DateTime ExpiryDate;
    public string CashierName;
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите количество записей:");
        int n = int.Parse(Console.ReadLine());

        Medicine[] medicines = new Medicine[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Введите информацию о лекарстве №{i + 1}:");
            Console.WriteLine("Название:");
            medicines[i].Name = Console.ReadLine();
            Console.WriteLine("Тип (внутреннее/наружное):");
            medicines[i].Type = Console.ReadLine();
            Console.WriteLine("Дата изготовления (гггг-мм-дд):");
            medicines[i].ManufacturingDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Срок годности (гггг-мм-дд):");
            medicines[i].ExpiryDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("ФИО кассира (продавца):");
            medicines[i].CashierName = Console.ReadLine();
            Console.WriteLine();
        }

        Console.WriteLine("Введите критерий поиска (название/тип/дата изготовления/срок годности/фио кассира):");
        string searchCriteria = Console.ReadLine();

        switch (searchCriteria)
        {
            case "название":
                Console.WriteLine("Введите название:");
                string name = Console.ReadLine();
                for (int i = 0; i < n; i++)
                {
                    if (medicines[i].Name == name)
                    {
                        Console.WriteLine($"Лекарство №{i + 1}:");
                        Console.WriteLine($"Название: {medicines[i].Name}");
                        Console.WriteLine($"Тип: {medicines[i].Type}");
                        Console.WriteLine($"Дата изготовления: {medicines[i].ManufacturingDate}");
                        Console.WriteLine($"Срок годности: {medicines[i].ExpiryDate}");
                        Console.WriteLine($"ФИО кассира (продавца): {medicines[i].CashierName}");
                        Console.WriteLine();
                    }
                }
                break;
            case "тип":
                Console.WriteLine("Введите тип (внутреннее/наружное):");
                string type = Console.ReadLine();
                for (int i = 0; i < n; i++)
                {
                    if (medicines[i].Type == type)
                    {
                        Console.WriteLine($"Лекарство №{i + 1}:");
                        Console.WriteLine($"Название: {medicines[i].Name}");
                        Console.WriteLine($"Тип: {medicines[i].Type}");
                        Console.WriteLine($"Дата изготовления: {medicines[i].ManufacturingDate}");
                        Console.WriteLine($"Срок годности: {medicines[i].ExpiryDate}");
                        Console.WriteLine($"ФИО кассира (продавца): {medicines[i].CashierName}");
                        Console.WriteLine();
                    }
                }
                break;
            case "дата изготовления":
                Console.WriteLine("Введите дату изготовления (гггг-мм-дд):");
                DateTime manufacturingDate = DateTime.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    if (medicines[i].ManufacturingDate == manufacturingDate)
                    {
                        Console.WriteLine($"Лекарство №{i + 1}:");
                        Console.WriteLine($"Название: {medicines[i].Name}");
                        Console.WriteLine($"Тип: {medicines[i].Type}");
                        Console.WriteLine($"Дата изготовления: {medicines[i].ManufacturingDate}");
                        Console.WriteLine($"Срок годности: {medicines[i].ExpiryDate}");
                        Console.WriteLine($"ФИО кассира (продавца): {medicines[i].CashierName}");
                        Console.WriteLine();
                    }
                }
                break;
            case "срок годности":
                Console.WriteLine("Введите срок годности (гггг-мм-дд):");
                DateTime expiryDate = DateTime.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    if (medicines[i].ExpiryDate == expiryDate)
                    {
                        Console.WriteLine($"Лекарство №{i + 1}:");
                        Console.WriteLine($"Название: {medicines[i].Name}");
                        Console.WriteLine($"Тип: {medicines[i].Type}");
                        Console.WriteLine($"Дата изготовления: {medicines[i].ManufacturingDate}");
                        Console.WriteLine($"Срок годности: {medicines[i].ExpiryDate}");
                        Console.WriteLine($"ФИО кассира (продавца): {medicines[i].CashierName}");
                        Console.WriteLine();
                    }
                }
                break;
            case "фио кассира":
                Console.WriteLine("Введите ФИО кассира (продавца):");
                string cashierName = Console.ReadLine();
                for (int i = 0; i < n; i++)
                {
                    if (medicines[i].CashierName == cashierName)
                    {
                        Console.WriteLine($"Лекарство №{i + 1}:");
                        Console.WriteLine($"Название: {medicines[i].Name}");
                        Console.WriteLine($"Тип: {medicines[i].Type}");
                        Console.WriteLine($"Дата изготовления: {medicines[i].ManufacturingDate}");
                        Console.WriteLine($"Срок годности: {medicines[i].ExpiryDate}");
                        Console.WriteLine($"ФИО кассира (продавца): {medicines[i].CashierName}");
                        Console.WriteLine();
                    }
                }
                break;
            default:
                Console.WriteLine("Некорректный критерий поиска.");
                break;
        }
    }
}