namespace The_best_calc
{
    public class Addition : ICalculator
    {
        public double Action(double first, double second)
        {
            return first + second;
        } 
    }
}