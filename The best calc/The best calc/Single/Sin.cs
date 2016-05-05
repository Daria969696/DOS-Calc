using System;

namespace The_best_calc.Single
{
    public class Sin : ISingle
    {
        /// <summary>
        /// вычисление синуса
        /// </summary>
        /// <param name="first">аргумент</param>
        /// <returns></returns>
        public double Action(double first)
        {
            return Math.Sin(first);
        }
         
    }
}