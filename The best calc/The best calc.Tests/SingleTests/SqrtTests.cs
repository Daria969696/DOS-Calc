using System;
using NUnit.Framework;
using The_best_calc.Single;

namespace The_best_calc.Tests.SingleTests
{
    [TestFixture]
    public class SqrtTests
    {
        [TestCase(4, 2)]
        [TestCase(1, 1)]
        [TestCase(0, 0)]
        [TestCase(121, 11)]
        [TestCase(49, 7)]
        public void SimpleTest(double arg, double expected)
        {
            Sqrt calc = new Sqrt();
            double result = calc.Action(arg);
            Assert.AreEqual(expected, result);
        }
        public void Negative()
        {
            Sqrt calc = new Sqrt();
            Assert.Throws<Exception>(() => calc.Action(-56));
        }
    }
}