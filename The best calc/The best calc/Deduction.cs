namespace The_best_calc
{
    public class Deduction : ICalculator
    {
        public double Action(double first, double second)
        {
            return first - second;
        } 
    }
}