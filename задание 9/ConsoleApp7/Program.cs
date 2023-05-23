using System;

public class Item
{
    public string name;
    public string madeDate;
    public string outDate;
    public string type;
    public string cashierName;
    public Item next; 

    public Item(string name, string madeDate, string outDate, string type, string cashierName)
    {
        this.name = name;
        this.madeDate = madeDate;
        this.outDate = outDate;
        this.type = type;
        this.cashierName = cashierName;
        this.next = null;
    }
}

public class LinkedList
{
    public Item head; 

    public LinkedList()
    {
        this.head = null;
    }

    public void AddFirst(Item item)
    {
        if (head == null)
        {
            head = item;
        }
        else
        {
            item.next = head;
            head = item;
        }
    }

    public void AddLast(Item item)
    {
        if (head == null)
        {
            head = item;
        }
        else
        {
            Item current = head;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = item;
        }
    }

    public void Find(string searchCriteria)
    {
        Item current = head;
        while (current != null)
        {
            if (current.name == searchCriteria || current.madeDate == searchCriteria || current.outDate == searchCriteria || current.type == searchCriteria || current.cashierName == searchCriteria)
            {
                Console.WriteLine("Название лекарства: {0}\nДата изготовления: {1}\nГоден до: {2}\nТип применения: {3}\nФИО Кассира: {4}\n ", current.name, current.madeDate, current.outDate, current.type, current.cashierName);
                return;
            }
            current = current.next;
        }
        Console.WriteLine("Запись не найдена.");
    }

    public void Insert(Item newItem, string searchCriteria, bool before)
    {
        if (head == null)
        {
            head = newItem;
        }
        else
        {
            Item current = head;
            Item prev = null;
            while (current != null)
            {
                if (current.name == searchCriteria || current.madeDate == searchCriteria || current.outDate == searchCriteria || current.type == searchCriteria || current.cashierName == searchCriteria)
                {
                    if (before)
                    {
                        if (prev == null)
                        {
                            newItem.next = head;
                            head = newItem;
                        }
                        else
                        {
                            newItem.next = current;
                            prev.next = newItem;
                        }
                    }
                    else
                    {
                        newItem.next = current.next;
                        current.next = newItem;
                    }
                    return;
                }
                prev = current;
                current = current.next;
            }
            Console.WriteLine("Запись не найдена.");
        }
    }

    public void Remove(string searchCriteria)
    {
        if (head == null)
        {
            Console.WriteLine("Список пуст.");
        }
        else if (head.name == searchCriteria || head.madeDate == searchCriteria || head.outDate == searchCriteria || head.type == searchCriteria || head.cashierName == searchCriteria)
        {
            head = head.next;
        }
        else
        {
            Item current = head;
            Item prev = null;
            while (current != null)
            {
                if (current.name == searchCriteria || current.madeDate == searchCriteria || current.outDate == searchCriteria || current.type == searchCriteria || current.cashierName == searchCriteria)
                {
                    prev.next = current.next;
                    return;
                }
                prev = current;
                current = current.next;
            }
            Console.WriteLine("Запись не найдена");
        }
    }
    public void View()
    {
        Item current = head;
        while (current != null)
        {
            Console.WriteLine("Название лекарства: {0}\nДата изготовления: {1}\nГоден до: {2}\nТип применения: {3}\nФИО Кассира: {4}\n ", current.name, current.madeDate, current.outDate, current.type, current.cashierName);
            current = current.next;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        LinkedList list = new LinkedList();
        int n = 0;
        Console.Write("Введите количество записей в списке: ");
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.Write("Ошибка ввода. Введите положительное число: ");
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Веедите данные для записи {0}:", i + 1);
            Console.Write("Название лекарства: ");
            string name = Console.ReadLine();
            Console.Write("Дата изготовления: ");
            string madeDate = Console.ReadLine();
            Console.Write("Годен до: ");
            string outDate = Console.ReadLine();
            Console.Write("Тип применения (внутр/наружн): ");
            string type = Console.ReadLine();
            Console.Write("ФИО Кассира: ");
            string cashierName = Console.ReadLine();
            Item item = new Item(name, madeDate, outDate, type, cashierName);
            list.AddLast(item);
        }

        while (true)
        {
            Console.WriteLine("\nВыберите действие:");
            Console.WriteLine("1 - Просмотреть список");
            Console.WriteLine("2 - Найти запись");
            Console.WriteLine("3 - Вставить запись до");
            Console.WriteLine("4 - Вставить запись после");
            Console.WriteLine("5 - Удалить запись");
            Console.WriteLine("6 - Выход");
            int choice = 0;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 6)
            {
                Console.Write("Ошибка ввода. Введите число от 1 до 6: ");
            }
            Console.WriteLine();
            switch (choice)
            {
                case 1:
                    list.View();
                    break;
                case 2:
                    Console.Write("Введите критерии поиска (Название лекарства, дата изготовления, годен до, тип применения, ФИО Кассира): ");
                    string searchCriteria = Console.ReadLine();
                    list.Find(searchCriteria);
                    break;
                case 3:
                    Console.Write("Введите критерии поиска (Название лекарства, дата изготовления, годен до, тип применения, ФИО Кассира): ");
                    searchCriteria = Console.ReadLine();
                    Console.WriteLine("Введите данные для новой записи:");
                    Console.Write("Название лекарства: ");
                    string name = Console.ReadLine();
                    Console.Write("Дата изготовления: ");
                    string madeDate = Console.ReadLine();
                    Console.Write("Годен до: ");
                    string outDate = Console.ReadLine();
                    Console.Write("Тип применения (внутр/наружн): ");
                    string type = Console.ReadLine();
                    Console.Write("ФИО Кассира: ");
                    string cashierName = Console.ReadLine();
                    Item newItem = new Item(name, madeDate, outDate, type, cashierName);
                    list.Insert(newItem, searchCriteria, true);
                    break;
                case 4:
                    Console.Write("Введите критерии поиска (Название лекарства, дата изготовления, годен до, тип применения, ФИО Кассира): ");
                    searchCriteria = Console.ReadLine();
                    Console.WriteLine("Введите данные для новой записи:");
                    Console.Write("Название лекарства: ");
                    name = Console.ReadLine();
                    Console.Write("Дата изготовления: ");
                    madeDate = Console.ReadLine();
                    Console.Write("Годен до: ");
                    outDate = Console.ReadLine();
                    Console.Write("Тип применения (внутр/наружн): ");
                    type = Console.ReadLine();
                    Console.Write("ФИО Кассира: ");
                    cashierName = Console.ReadLine();
                    newItem = new Item(name, madeDate, outDate, type, cashierName);
                    list.Insert(newItem, searchCriteria, false);
                    break;
                case 5:
                    Console.Write("Введите критерии поиска (Название лекарства, дата изготовления, годен до, тип применения, ФИО Кассира): ");
                    searchCriteria = Console.ReadLine();
                    list.Remove(searchCriteria);
                    break;
                case 6:
                    return;
            }
        }
    }
}