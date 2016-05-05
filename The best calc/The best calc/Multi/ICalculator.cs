namespace The_best_calc.Multi
{
    public interface ICalculator
    {
        /// <summary>
        /// выполнить действие
        /// </summary>
        /// <param name="first">первый аргумент</param>
        /// <param name="second">второй аргумент</param>
        /// <returns></returns>
        double Action(double first, double second);
    }
}