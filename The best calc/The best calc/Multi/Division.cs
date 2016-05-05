using System;

namespace The_best_calc.Multi
{
    public class Division : ICalculator
    {
        /// <summary>
        /// деление двух аргументов
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
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