﻿using System;
using NUnit.Framework;
using The_best_calc.Single;

namespace The_best_calc.Tests.SingleTests
{
    [TestFixture]
    public class LnTests
    {
        [TestCase(Math.E, 1)]
        [TestCase(1, 0)]
        public void SimpleTest(double arg, double expected)
        {
            Ln calc = new Ln();
            double result = calc.Action(arg);
            Assert.AreEqual(expected, result);
        }     
    }
}