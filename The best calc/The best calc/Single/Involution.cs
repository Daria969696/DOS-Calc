using System;

namespace The_best_calc.Single
{
    public class Involution : ISingle
    {
        /// <summary>
        /// возведение в квадрат
        /// </summary>
        /// <param name="first">аргумент</param>
        /// <returns></returns>
        public double Action(double first)
        {
            return Math.Pow(first, 2);
        }
    }
}