using NUnit.Framework;
using The_best_calc.Multi;

namespace The_best_calc.Tests.MultiTests
{
     [TestFixture]
    public class DivisionTests
    {
         [Test]
         public void SimpleTest()
         {
             Division calc = new Division();
             double result = calc.Action(6, 6);
             Assert.AreEqual(1, result);
             result = calc.Action(48, 6);
             Assert.AreEqual(8, result);
             result = calc.Action(-6, 6);
             Assert.AreEqual(-1, result);
         }
    }
}