using NUnit.Framework;
using The_best_calc.Multi;

namespace The_best_calc.Tests.MultiTests
{
    [TestFixture]
    public class DeductionTests
    {
        [Test]
        public void SimpleTest()
        {
            Deduction calc = new Deduction();
            double result = calc.Action(5, 6);
            Assert.AreEqual(-1, result);
            result = calc.Action(48, 6);
            Assert.AreEqual(42, result);
            result = calc.Action(0.23, 6);
            Assert.AreEqual(-5.77, result);
        }
    }
}