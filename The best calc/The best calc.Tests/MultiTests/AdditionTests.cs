using NUnit.Framework;
using The_best_calc.Multi;

namespace The_best_calc.Tests.MultiTests
{
    [TestFixture]
    public class AdditionTests
    {
        [Test]
        public void SimpleTest()
        {
            Addition calc = new Addition();
            double result = calc.Action(5, 6);
            Assert.AreEqual(11, result);
        }
    }
}