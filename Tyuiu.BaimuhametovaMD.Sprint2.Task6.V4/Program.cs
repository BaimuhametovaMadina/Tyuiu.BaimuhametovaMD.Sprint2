using Tyuiu.BaimuhametovaMD.Sprint2.Task6.V4.Lib;

namespace Tyuiu.BaimuhametovaMD.Sprint2.Task6.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Баймухаметова М.Д. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Получение результата из switch                                    *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Баймухаметова Мадина | ИБКСб-24-1                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Мастям игральных карт условно присвоены следующие порядковые номера:    *");
            Console.WriteLine("* масти «пики» — 1, масти «трефы» — 2,                                    *");
            Console.WriteLine("* масти «бубны» — 3, масти «червы» — 4.                                   *");
            Console.WriteLine("* По заданному номеру масти m (1 <= m <= 4) определить название           *");
            Console.WriteLine("* соответствующей масти.                                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите номер масти: ");
            int value = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Название масти с заданным номером: " + ds.FindCardSuit(value));
            Console.ReadLine();
        }
    }
}
