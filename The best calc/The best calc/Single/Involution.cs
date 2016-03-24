using System;

namespace The_best_calc.Single
{
    public class Involution : ISingle
    {
        public double Action(double first)
        {
            return Math.Pow(first, 2);
        }
    }
}