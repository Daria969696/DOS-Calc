using System;
using NUnit.Framework;
using The_best_calc.Single;

namespace The_best_calc.Tests.SingleTests
{
    [TestFixture]
    public class LgTests
    {
        [TestCase(10, 1)]
        [TestCase(100, 2)]
        [TestCase(0.1, -1)]
        public void SimpleTest(double arg, double expected)
        {
            Lg calc = new Lg();
            double result = calc.Action(arg);
            Assert.AreEqual(expected, result);
        }    
    }
}