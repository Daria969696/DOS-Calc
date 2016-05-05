namespace The_best_calc.Multi
{
    public class Addition : ICalculator
    {
        /// <summary>
        /// сложение двух аргументов
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public double Action(double first, double second)
        {
            return first + second;
        } 
    }
}