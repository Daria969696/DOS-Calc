using System;

namespace The_best_calc.Single
{
    public class Tg : ISingle
    {
        public double Action(double first)
        {
            return Math.Tan(first);
        }
    }
}