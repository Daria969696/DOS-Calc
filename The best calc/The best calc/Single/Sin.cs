using System;

namespace The_best_calc.Single
{
    public class Sin : ISingle
    {
        public double Action(double first)
        {
            return Math.Sin(first);
        }
         
    }
}