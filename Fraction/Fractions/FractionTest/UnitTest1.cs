using Fractions;
using System.Security.Cryptography.X509Certificates;

namespace FractionTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreateFraction()
        {
            Fraction f = new Fraction(3);
            Assert.IsNotNull(f);
        }
        [TestMethod]
        public void CreateFractionWithDenominateur()
        {
                Fraction f2 = new Fraction(1,1);
                Assert.IsNotNull(f2);
        }

        [TestMethod]
        public void OpposeFraction()
        {
            Fraction test = new Fraction(10);
            test.Oppose();
            Assert.AreEqual(-10,test.Numerateur);
        }

        [TestMethod]
        public void InverseFraction()
        {
            Fraction test = new Fraction(10,5);
            test.Inverse();
            Assert.AreEqual(5, test.Numerateur);
            Assert.AreEqual(10, test.Denominateur);
        }

        [TestMethod]
        public void CompareSuperiorAtReturnTrue()
        {
            Fraction test = new Fraction(15, 5);
            Fraction toCompare = new Fraction(10, 5);
            Assert.IsTrue(test.SuperieurA(toCompare));
        }

        [TestMethod]
        public void CompareIsEqualTo()
        {
            Fraction test = new Fraction(10, 5);
            Fraction toCompare = new Fraction(10, 5);
            Assert.IsTrue(test.EgalA(toCompare));
        }

        [TestMethod]
        public void AddTwoFraction()
        {
            Fraction test = new Fraction(5, 7);
            Fraction toCompare = new Fraction(9, 11);
            test = test.Plus(toCompare);
            Assert.AreEqual(118,test.Numerateur);
            Assert.AreEqual(77, test.Denominateur);
        }

        [TestMethod]
        public void ReduceFraction()
        {
            Fraction test = new Fraction(5, 7);
            Fraction toCompare = new Fraction(9, 11);
            test = test.Moins(toCompare);
            Assert.AreEqual(-8, test.Numerateur);
            Assert.AreEqual(77, test.Denominateur);
        }

        [TestMethod]
        public void MultiplieFraction()
        {
            Fraction test = new Fraction(3, 4);
            Fraction toCompare = new Fraction(2, 3);
            test = test.Multiplie(toCompare);
            Assert.AreEqual(1, test.Numerateur);
            Assert.AreEqual(2, test.Denominateur);
        }

        [TestMethod]
        public void DivideFraction()
        {
            Fraction test = new Fraction(3, 4);
            Fraction toCompare = new Fraction(2, 3);
            test = test.Divise(toCompare);
            Assert.AreEqual(9, test.Numerateur);
            Assert.AreEqual(8, test.Denominateur);
        }

    }
}