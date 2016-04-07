using System;
using NUnit.Framework;
using The_best_calc.Single;

namespace The_best_calc.Tests.SingleTests
{
     [TestFixture]
    public class TgTests
    {
         [TestCase(0, 0)]
         [TestCase(Math.PI /4, 1)]
         public void SimpleTest(double arg, double expected)
         {
             Tg calc = new Tg();
             double result = calc.Action(arg);
             Assert.AreEqual(expected, result, 0.1);
         }   
    }
}