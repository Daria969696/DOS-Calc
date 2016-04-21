using System;

namespace The_best_calc.Single
{
    public class Tg : ISingle
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public double Action(double first)
        {
            if (first == (Math.PI / 2) )
                throw new Exception("Тангенс Pi/2 не существует");
            if (first == (-Math.PI / 2))
                throw new Exception("Тангенс -Pi/2 не существует");
            return Math.Tan(first);
        }
    }
}