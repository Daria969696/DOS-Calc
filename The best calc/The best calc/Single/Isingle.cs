namespace The_best_calc.Single
{
    public interface ISingle
    {
        /// <summary>
        /// действие над одним аргументом
        /// </summary>
        /// <param name="first">аргумент</param>
        /// <returns></returns>
        double Action(double first);
    }
}