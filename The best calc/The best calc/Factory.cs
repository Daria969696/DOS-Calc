using System;

namespace The_best_calc
{
    public static class Factory
    {
        public static ICalculator Create(string name)
        {
            switch (name)
            {
                case "button1":
                   return new Addition();
                case "button2":
                   return new Deduction();
                case "button3":
                   return new Multiplication();
                case "button4":
                   return new Division();
                default:
                    throw new Exception("Неизвестная операция");

            }
        }
    }
}