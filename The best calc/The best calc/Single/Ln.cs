using System;

namespace The_best_calc.Single
{
    public class Ln : ISingle
    {
        public double Action(double first)
        {
            return Math.Log(first);
        }
    }
}