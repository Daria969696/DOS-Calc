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
                throw new Exception("������� Pi/2 �� ����������");
            if (first == (-Math.PI / 2))
                throw new Exception("������� -Pi/2 �� ����������");
            return Math.Tan(first);
        }
    }
}