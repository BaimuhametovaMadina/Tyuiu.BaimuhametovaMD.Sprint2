using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BaimuhametovaMD.Sprint2.Task3.V5.Lib
{
    public class DataService: ISprint2Task3V5
    {
        public double Calculate(double x)
        {
            if (x > 1) return Math.Round((x - Math.Pow((x + 1) / (x - 1), x)), 3);
            else if (x == 0) return Math.Round(((x * x - Math.Cos(x * x)) / (x * x - Math.Sin(x * x) + 12)), 3);
            else if (x < 0 && x > -9) return Math.Round(Math.Pow(6 + (4 / (x * x)), x), 3);
            else if (x < -9) return Math.Round((x * x * x + 10 * x - ((x * x) / (x * x * x * x))), 3);
            else return 0;
        }
    }
}
