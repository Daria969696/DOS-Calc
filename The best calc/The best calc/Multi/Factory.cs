using System;

namespace The_best_calc.Multi
{
    /// <summary>
    /// 
    /// </summary>
    public static class Factory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
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