using System;

namespace The_best_calc.Single
{
    public class Cos : ISingle
    {
        /// <summary>
        /// вычисление косинуса
        /// </summary>
        /// <param name="first">аргумент</param>
        /// <returns></returns>
        public double Action(double first)
        {
            return Math.Cos(first);
        }
    }
}