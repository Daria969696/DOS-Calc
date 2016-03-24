using System;

namespace The_best_calc.Single
{
    public class Lg : ISingle
    {
        public double Action(double first)
        {
            return Math.Log10(first);
        }
    }
}