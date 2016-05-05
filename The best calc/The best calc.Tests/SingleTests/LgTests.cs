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

        public void Zero()
        {
            Lg calc = new Lg();
            Assert.Throws<Exception>(() => calc.Action(0));
        }
        public void Negative()
        {
            Lg calc = new Lg();
            Assert.Throws<Exception>(() => calc.Action(-9));
        }
    }
}