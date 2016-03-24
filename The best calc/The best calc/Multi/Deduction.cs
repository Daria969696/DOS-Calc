namespace The_best_calc.Multi
{
    public class Deduction : ICalculator
    {
        public double Action(double first, double second)
        {
            return first - second;
        } 
    }
}