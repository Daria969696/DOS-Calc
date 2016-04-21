namespace The_best_calc.Multi
{
    /// <summary>
    /// 
    /// </summary>
    public class Addition : ICalculator
    {
        /// <summary>
        /// 
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