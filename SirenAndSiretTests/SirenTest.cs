using Microsoft.VisualStudio.TestTools.UnitTesting;
using SirenAndSiret.Classes;

namespace SirenAndSiretTests
{
    [TestClass]
    public class SirenTest
    {
        [TestMethod]
        public void TestInvalidSirenIsInvalid()
        {
            Siren siren = new Siren("800403223"); // Invalid
            Assert.IsFalse(siren.IsValid);
        }
        [TestMethod]
        public void TestValidSirenIsValid()
        {
            Siren siren = new Siren("732829320"); // Valid
            Assert.IsTrue(siren.IsValid);
        }
        [TestMethod]
        public void TestToLongSirenIsInvalid()
        {
            Siren siren = new Siren("89564753256"); // To Long
            Assert.IsFalse(siren.IsValid);
        }
        [TestMethod]
        public void TestToShortSirenIsInvalid()
        {
            Siren siren = new Siren("6879546"); // To Short
            Assert.IsFalse(siren.IsValid);
        }

    }
}
