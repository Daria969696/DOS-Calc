using System;

namespace The_best_calc.Single
{
    public class Atg : ISingle
    {
        /// <summary>
        /// вычисление арктангенса
        /// </summary>
        /// <param name="first">аргумент</param>
        /// <returns></returns>
        public double Action(double first)
        {
            return Math.Atan(first);
        }
    }
}