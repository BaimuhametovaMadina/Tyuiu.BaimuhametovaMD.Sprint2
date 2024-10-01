﻿using Tyuiu.BaimuhametovaMD.Sprint2.Task1.V8.Lib;

namespace Tyuiu.BaimuhametovaMD.Sprint2.Task1.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int a = 15, b = 16, c = 14, d = 335;
            Console.Title = "Спринт #2 | Выполнил: Баймухаметова М.Д. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Логические операции                                               *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Баймухаметова Мадина | ИБКСб-24-1                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений                                *");
            Console.WriteLine("* (==, !=, <, >, <=, >=, последовательность можно чередовать,             *");
            Console.WriteLine("* но использовать один раз в выражении) и логических операций             *");
            Console.WriteLine("* (|, &, ||, &&, !, ^, последовательность операций не должна нарушаться), *");
            Console.WriteLine("* а также арифметических выражений,                                       *");
            Console.WriteLine("* которая вернет логическую последовательность(массив):                   *");
            Console.WriteLine("* (True, False, True, False, False, False),                               *");
            Console.WriteLine("* при a = 15, b = 16, c = 14, d = 335                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* a = 15, b = 16, c = 14, d = 335                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Массив результатов операций сравнения: ");
            bool[] res = ds.GetLogicOperations(a, b, c, d);
            foreach (bool val in res) { Console.Write(val + " "); }
            Console.ReadLine();
        }
    }
}
