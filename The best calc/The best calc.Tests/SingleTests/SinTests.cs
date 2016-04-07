using System;
using NUnit.Framework;
using The_best_calc.Single;

namespace The_best_calc.Tests.SingleTests
{
    [TestFixture]
    public class SinTests
    {
        [TestCase(0, 0)]
        [TestCase(Math.PI / 6, 0.5)]
        public void SimpleTest(double arg, double expected)
        {
            Sin calc = new Sin();
            double result = calc.Action(arg);
            Assert.AreEqual(expected, result, 0.1);
        }   
    }
}