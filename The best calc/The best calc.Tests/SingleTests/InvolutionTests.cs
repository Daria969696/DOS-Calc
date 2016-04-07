using System;
using NUnit.Framework;
using The_best_calc.Single;

namespace The_best_calc.Tests.SingleTests
{
    [TestFixture]
    public class InvolutionTests
    {
        [TestCase(2, 4)]
        [TestCase(1, 1)]
        [TestCase(0, 0)]
        [TestCase(11, 121)]
        [TestCase(-25, 625)]
        public void SimpleTest(double arg, double expected)
        {
            Involution calc = new Involution();
            double result = calc.Action(arg);
            Assert.AreEqual(expected, result);
        }         
    }
}