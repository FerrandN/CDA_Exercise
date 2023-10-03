using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Given_nombre_When_FizzBuzzPourUnNombre_Then_ReturnNombre()
        {
            //Arrange
            string retour;
            int nombre = 1;
            //Act
            retour = FizzBuzzWithTDD.Program.ReferenceEquals(nombre);
            //Assert
            Assert.AreEqual("1", retour.ToString());
        }

        [TestMethod]
        public void Given_nombre3_When_FizzBuzzPourUnNombre_Then_ReturnFizz()
        {
            //Arrange
            string retour;
            int nombre = 3;
            //Act
            retour = FizzBuzzWithTDD.Program.ReferenceEquals(nombre);
            //Assert
            Assert.AreEqual("fizz", retour);
        }

        [TestMethod]
        public void Given_nombre6_When_FizzBuzzPourUnNombre_Then_ReturnFizz()
        {
            //Arrange
            string retour;
            int nombre = 6;
            //Act
            retour = FizzBuzzWithTDD.Program.ReferenceEquals(nombre);
            //Assert
            Assert.AreEqual("fizz", retour);
        }

        [TestMethod]
        public void Given_nombre5_When_FizzBuzzPourUnNombre_Then_ReturnBuzz()
        {
            //Arrange
            string retour;
            int nombre = 5;
            //Act
            retour = FizzBuzzWithTDD.Program.ReferenceEquals(nombre);
            //Assert
            Assert.AreEqual("buzz", retour);
        }

        [TestMethod]
        public void Given_nombre10_When_FizzBuzzPourUnNombre_Then_ReturnBuzz()
        {
            //Arrange
            string retour;
            int nombre = 10;
            //Act
            retour = FizzBuzzWithTDD.Program.ReferenceEquals(nombre);
            //Assert
            Assert.AreEqual("buzz", retour);
        }

        [TestMethod]
        public void Given_nombre15_When_FizzBuzzPourUnNombre_Then_ReturnBuzz()
        {
            //Arrange
            string retour;
            int nombre = 15;
            //Act
            retour = FizzBuzzWithTDD.Program.ReferenceEquals(nombre);
            //Assert
            Assert.AreEqual("fizzbuzz", retour);
        }

        [TestMethod]
        public void Given_nombre30_When_FizzBuzzPourUnNombre_Then_ReturnBuzz()
        {
            //Arrange
            string retour;
            int nombre = 30;
            //Act
            retour = FizzBuzzWithTDD.Program.ReferenceEquals(nombre);
            //Assert
            Assert.AreEqual("fizzbuzz", retour);
        }
    }
}