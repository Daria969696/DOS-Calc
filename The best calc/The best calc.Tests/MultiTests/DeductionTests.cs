using NUnit.Framework;
using The_best_calc.Multi;

namespace The_best_calc.Tests.MultiTests
{
    [TestFixture]
    public class DeductionTests
    {
        [TestCase(5, 6, -1)]
        [TestCase(0, 0, 0)]
        [TestCase(78, 6, 72)]
        [TestCase(-98.32, -6, -92.32)]
        public void SimpleTest(double first, double second, double expected)
        {
            Deduction calc = new Deduction();
            double result = calc.Action(first, second);
            Assert.AreEqual(expected, result);        
        }
    }
}