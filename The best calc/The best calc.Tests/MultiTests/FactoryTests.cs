using System;
using NUnit.Framework;
using The_best_calc.Multi;

namespace The_best_calc.Tests.MultiTests
{
    [TestFixture]
    public class FactoryTests
    {
        [TestCase("button1", typeof(Addition))]
        [TestCase("button2", typeof(Deduction))]
        [TestCase("button3", typeof(Multiplication))]
        [TestCase("button4", typeof(Division))]
        public void CreateCalculatorTest(string name, Type expected)
        {
            ICalculator calc = Factory.Create(name);
            Assert.IsInstanceOf(expected, calc);
        }
    }
}