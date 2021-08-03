using Microsoft.VisualStudio.TestTools.UnitTesting;
using SirenAndSiret.Classes;

namespace SirenAndSiretTests
{
    [TestClass]
    public class SiretTest
    {
        [TestMethod]
        public void TestInvalidSiretIsInvalidFirstConstructor()
        {
            Siret siret = new Siret("800403222","00015"); // invalid, first constructor
            Assert.IsFalse(siret.IsValid);
        }
        [TestMethod]
        public void TestValidSiretIsValidFirstConstructor()
        {
            Siret siret = new Siret("800403222","00014"); // valid, first constructor
            Assert.IsTrue(siret.IsValid);
        }
        [TestMethod]
        public void TestToLongSiretIsValidFirstConstructor()
        {
            Siret siret = new Siret("800403222000","1512584653"); // To Long, first constructor
            Assert.IsFalse(siret.IsValid);
        }
        [TestMethod]
        public void TestToShortSiretIsValidFirstConstructor()
        {
            Siret siret = new Siret("8004032220","001512584653"); // To Short , first constructor
            Assert.IsFalse(siret.IsValid);
        }
        [TestMethod]
        public void TestInvalidSiretIsInvalidSecondConstructor()
        {
            Siret siret = new Siret(new Siren("800403222"), "00015"); // invalid, second constructor
            Assert.IsFalse(siret.IsValid);
        }
        [TestMethod]
        public void TestValidSiretIsValidSecondConstructor()
        {
            Siret siret = new Siret(new Siren("800403222"), "00014"); // valid, second constructor
            Assert.IsTrue(siret.IsValid);
        }
        [TestMethod]
        public void TestToLongSiretIsValidFSecondConstructor()
        {
            Siret siret = new Siret(new Siren("800403222000"), "1512584653"); // To Long, second constructor
            Assert.IsFalse(siret.IsValid);
        }
        [TestMethod]
        public void TestToShortSiretIsValidSecondConstructor()
        {
            Siret siret = new Siret(new Siren("8004032220"), "001512584653"); // To Short , second constructor
            Assert.IsFalse(siret.IsValid);
        }

        [TestMethod]
        public void TestInvalidSiretIsInvalidThirdConstructor()
        {
            Siret siret = new Siret("80040322200015"); // invalid, third constructor
            Assert.IsFalse(siret.IsValid);
        }
        [TestMethod]
        public void TestValidSiretIsValidThirdConstructor()
        {
            Siret siret = new Siret("80040322200014"); // valid, third constructor
            Assert.IsTrue(siret.IsValid);
        }
        [TestMethod]
        public void TestToLongSiretIsValidThirdConstructor()
        {
            Siret siret = new Siret("8004032220001512584653"); // To Long, third constructor
            Assert.IsFalse(siret.IsValid);
        }
        [TestMethod]
        public void TestToShortSiretIsValidThirdConstructor()
        {
            Siret siret = new Siret("8004032220001512584653"); // To Short , third constructor
            Assert.IsFalse(siret.IsValid);
        }

    }
}
