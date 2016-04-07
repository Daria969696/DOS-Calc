using NUnit.Framework;
using The_best_calc.Multi;

namespace The_best_calc.Tests.MultiTests
{
     [TestFixture]
    public class MultiplicationTests
    {
        [TestCase(5, 6, 30)]
        [TestCase(0, 0, 0)]
        [TestCase(-8, 6, -48)]
        [TestCase(-9, -6, 54)]
        [TestCase(0.25, 4, 1)]
        public void SimpleTest(double first, double second, double expected)
        {
            Multiplication calc = new Multiplication();
            double result = calc.Action(first, second);
            Assert.AreEqual(expected, result);
        } 
    }
}