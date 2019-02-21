using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestchallenge8
{
    [TestClass]
    public class UnitTest1
    {
        
        
            RiskRepository _repo = new RiskRepository();

        [TestMethod]
        public void RiskModifiers_ShouldHoldCorrectValue()
        {
            Risk Risk = new Risk(1, 1, 1, 1);

            decimal actual = _repo.SpeedingMod(Risk);
            decimal expected = 1.05m;

            decimal actualTwo = _repo.SwervingMod(Risk);
            decimal expectedTwo = 1.05m;

            decimal actualThree = _repo.RollingStopMod(Risk);
            decimal expectedThree = 1.05m;

            decimal actualFour = _repo.TailgatingMod(Risk);
            decimal expectedFour = 1.05m;

            Assert.AreEqual(actual, expected);
            Assert.AreEqual(actualTwo, expectedTwo);
            Assert.AreEqual(actualThree, expectedThree);
            Assert.AreEqual(actualFour, expectedFour);

        }

        [TestMethod]
        public void MyTestMethod()
        {
            Risk Risk = new Risk(1, 1, 1, 1);

            decimal speedMod = _repo.SpeedingMod(Risk);
            decimal swerveMod = _repo.SwervingMod(Risk);
            decimal rollingStopMod = _repo.RollingStopMod(Risk);
            decimal tailgaitingMod = _repo.TailgatingMod(Risk);

            decimal unrounded = _repo.InsurancePremium(speedMod, swerveMod, tailgaitingMod, rollingStopMod);
            decimal actual = Decimal.Round(unrounded, 2);
            decimal expected = 243.10m;

            Assert.AreEqual(actual, expected);
        }
    }
}
