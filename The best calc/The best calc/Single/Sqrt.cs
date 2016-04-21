using System;

namespace The_best_calc.Single
{
    public class Sqrt : ISingle
    {
        public double Action(double first)
        {
            if (first <0)
                throw new Exception("Невозможно извлечь корень из отрицательного числа");
            return Math.Sqrt(first);
        }
    }
}