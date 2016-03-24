using System;

namespace The_best_calc.Single
{
    public class Atg : ISingle
    {
        public double Action(double first)
        {
            return Math.Atan(first);
        }
    }
}