using System;

namespace The_best_calc.Multi
{
    public class Division : ICalculator
    {
        public double Action(double first, double second)
        {
            if (second == 0)
            {
                throw new Exception("Деление на ноль невозможно");
            }
            return first / second;
        } 
    }
}