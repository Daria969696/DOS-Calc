using System;

namespace The_best_calc.Single
{
    public class Sqrt : ISingle
    {
        public double Action(double first)
        {
            return Math.Sqrt(first);
        }
    }
}