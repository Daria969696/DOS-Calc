using System;

namespace The_best_calc.Single
{
    public class Cos : ISingle
    {
        public double Action(double first)
        {
            return Math.Cos(first);
        }
    }
}