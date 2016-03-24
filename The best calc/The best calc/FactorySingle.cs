using System;

namespace The_best_calc
{
    public class FactorySingle
    {
        public static Isingle Create(string name)
        {
            switch (name)
            {
                case "button5":
                    return new Sin();
                case "button6":
                    return new Cos();
                case "button7":
                    return new Tg();
                case "button8":
                    return new Atg();
                case "button9":
                    return new Sqrt();
                case "button10":
                    return new Involution();
                case "button11":
                    return new Ln();
                case "button12":
                    return new Lg();
                default:
                    throw new Exception("Неизвестная операция");

            }
        } 
    }
}