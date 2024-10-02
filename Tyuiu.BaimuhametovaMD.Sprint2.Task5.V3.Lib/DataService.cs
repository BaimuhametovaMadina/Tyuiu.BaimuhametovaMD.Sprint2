using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BaimuhametovaMD.Sprint2.Task5.V3.Lib
{
    public class DataService: ISprint2Task5V3
    {
        public string FindDayName(int value)
        {
            switch (value)
            {
                case 1:
                    return "Понедельник";
                    break;
                case 2:
                    return "Вторник";
                    break;
                case 3:
                    return "Среда";
                    break;
                case 4:
                    return "Четверг";
                    break;
                case 5:
                    return "Пятница";
                    break;
                case 6:
                    return "Суббота";
                    break;
                case 7:
                    return "Воскресенье";
                    break;
                default: return "Дня с таким номером не существует";
            }
        }
    }
}
