using System;
using System.Collections.Generic;

namespace Str_List_17L
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "Tom", "Sam", "Bob" };
            LinkedList<string> people = new LinkedList<string>(names);
            Console.WriteLine("Начальный список:");
            DisplayList(people);
            Console.WriteLine("Сколько элементов добавить в список?");
            int n = 0;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Введена неверная форма числа! Попробуйте снова.");
            }
            Console.WriteLine("Добавить элементы в начало или конец?\n1.Начало\n2.Конец");
            int firstOrLast = 0;
            while (!int.TryParse(Console.ReadLine(), out firstOrLast))
            {
                Console.WriteLine("Введена неверная форма числа! Попробуйте снова.");
            }
            if (isFirstOrNot(firstOrLast))
            {
                AddFirst(n, people);
            }
            if (!isFirstOrNot(firstOrLast))
            {
                AddLast(n, people);
            }
            firstOrLast = 0;
            Console.WriteLine("Новый список до изменений:");
            DisplayList(people);
            Console.WriteLine("\nСделать копию, добавить элементы или закончить выполнение программы?\n1.Сделать копию\n2.Добавить\n0.Закончить");
            int chs = -1;
            while (chs != 0)
            {
                n = 0;
                while (!int.TryParse(Console.ReadLine(), out chs))
                {
                    Console.WriteLine("Введена неверная форма числа! Попробуйте снова.");
                }
                if (chs == 2)
                {
                    Console.WriteLine("Начальный список до изменений");
                    DisplayList(people);
                    Console.WriteLine("Сколько элементов добавить в список?");
                    n = 0;
                    while (!int.TryParse(Console.ReadLine(), out n))
                    {
                        Console.WriteLine("Введена неверная форма числа! Попробуйте снова.");
                    }
                    Console.WriteLine("Добавить элементы в начало или конец?\n1.Начало\n2.Конец");
                    firstOrLast = 0;
                    while (!int.TryParse(Console.ReadLine(), out firstOrLast))
                    {
                        Console.WriteLine("Введена неверная форма числа! Попробуйте снова.");
                    }
                }
                if (isFirstOrNot(firstOrLast))
                {
                    AddFirst(n, people);
                }
                if (!isFirstOrNot(firstOrLast))
                {
                    AddLast(n, people);
                }
                firstOrLast = 0;
                if (chs == 1)
                {
                    MakeReverseCopyToEnd(people);
                }
                Console.WriteLine("\nНовый список:");
                DisplayList(people);
                Console.WriteLine("\nСделать копию, добавить элементы или закончить выполнение программы?\n1.Сделать копию\n2.Добавить\n0.Закончить");
            }
            Console.WriteLine("Конец работы программы");
            LinkedList<string> MakeReverseCopyToEnd(LinkedList<string> list)
            {
                int numOfElem = list.Count;
                var str = list.Last;
                for (int i = 0; i < numOfElem;i++)
                {
                    list.AddLast(str.Value);
                    str = str.Previous;
                }
                return list;
            }
            void DisplayList(LinkedList<string> list)
            {
                var s = list.First;
                while (s != null)
                {
                    Console.Write(s.Value + " ");
                    s = s.Next;
                }
            }
            bool isFirstOrNot(int firstOrLast)
            {
                if (firstOrLast == 1)
                {
                    return true;
                }
                return false;
            }
            void AddFirst(int n, LinkedList<string> list)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Введите новый элемент списка №{i + 1}:");
                    list.AddFirst(Console.ReadLine());
                    Console.WriteLine("");
                }
            }
            void AddLast(int n, LinkedList<string> list)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Введите новый элемент списка №{i + 1}:");
                    list.AddLast(Console.ReadLine());
                    Console.WriteLine("");
                }
            }
        }
    }
}