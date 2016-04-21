using System;

namespace The_best_calc.Single
{
    public class Involution : ISingle
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public double Action(double first)
        {
            return Math.Pow(first, 2);
        }
    }
}