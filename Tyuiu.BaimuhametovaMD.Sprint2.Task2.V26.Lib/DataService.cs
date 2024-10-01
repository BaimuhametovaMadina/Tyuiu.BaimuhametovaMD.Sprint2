using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BaimuhametovaMD.Sprint2.Task2.V26.Lib
{
    public class DataService: ISprint2Task2V26
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if (x >= 3 && x <= 5 && (y >= 3 && y <= 7 || y == 11)) return true;
            else if ((x == 6 && y >= 5 && y <= 11) || (x <= 8 && x >= 7 && y <= 12 && y >= 5)) return true;
            else if (x == 9 && (y >= 3 && y <= 13)) return true;
            else if (x == 10 && (y >= 3 && y <= 8 || y >= 11 && y <= 13)) return true;
            else if (x >= 11 && x <= 12 && (y == 3 || y >= 6 && y <= 8 || y >= 11 && y <= 12)) return true;
            else if (x == 13 && y >= 6 && y <= 8) return true;
            else return false;
        }
    }
}
