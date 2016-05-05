using System;
using NUnit.Framework;
using The_best_calc.Single;

namespace The_best_calc.Tests.SingleTests
{
    [TestFixture]
    public class FactoryTests
    {
        [TestCase("button5", typeof(Sin))]
        [TestCase("button6", typeof(Cos))]
        [TestCase("button7", typeof(Tg))]
        [TestCase("button8", typeof(Atg))]
        [TestCase("button9", typeof(Sqrt))]
        [TestCase("button10", typeof(Involution))]
        [TestCase("button11", typeof(Ln))]
        [TestCase("button12", typeof(Lg))]
        public void CreateCalculatorTest(string name, Type expected)
        {
            ISingle calc = FactorySingle.Create(name);
            Assert.IsInstanceOf(expected, calc);
        }
    }
}