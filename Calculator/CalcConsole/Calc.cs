using System;

namespace CalcConsole
{
    public class Calc
    {
        #region int

        public int Sum(int x, int y)
        {
            return x + y;
        }

        public int Sub(int x, int y)
        {
            return x - y;
        }
        #endregion

        public double Sum(double x, double y)
        {
            return x + y;
        }

        public double Sub(double x, double y)
        {
            return x - y;
        }

        public double Div(double x, double y)
        {
            return x / y;
        }

        public double Sqrt(double x)
        {
            return Math.Sqrt(x);
        }

    }
}
