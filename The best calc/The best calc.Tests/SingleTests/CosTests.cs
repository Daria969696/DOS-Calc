using System;
using NUnit.Framework;
using The_best_calc.Single;

namespace The_best_calc.Tests.SingleTests
{
    [TestFixture]
    public class CosTests
    {
        [TestCase(0, 1)]
        [TestCase(Math.PI/3, 0.5)]
        public void SimpleTest(double arg, double expected)
        {
            Cos calc = new Cos();
            double result = calc.Action(arg);
            Assert.AreEqual(expected, result, 0.1);
        }  
    }
}