﻿using System;

namespace The_best_calc.Single
{
    public class Ln : ISingle
    {
        /// <summary>
        /// вычисление натурального логарифма с исключениями
        /// </summary>
        /// <param name="first">аргумент</param>
        /// <returns></returns>
        public double Action(double first)
        {
            if (first == 0)
                throw new Exception("Логарифм нуля равен -бесконечности");
            if (first <0)
                throw new Exception("Нельзя считать логарифм от отрицательного числа");
            return Math.Log(first);
        }
    }
}