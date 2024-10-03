﻿using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.BaimuhametovaMD.Sprint2.Task7.V11.Lib
{
    public class DataService: ISprint2Task7V11
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            if ((x*x + y*y < 1) && (y > x || (x < 0 && y < 0))) return true;
            return false;
        }
    }
}
