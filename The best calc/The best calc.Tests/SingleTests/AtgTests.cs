using System;
using NUnit.Framework;
using The_best_calc.Single;

namespace The_best_calc.Tests.SingleTests
{
    [TestFixture]
    public class AtgTests
    {
        [TestCase(0, 0)]
        public void SimpleTest(double arg, double expected)
        {
            Atg calc = new Atg();
            double result = calc.Action(arg);
            Assert.AreEqual(expected, result, 0.1);
        }  
    }
}