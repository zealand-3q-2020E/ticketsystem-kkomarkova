using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
namespace UnitTestTicketSystem
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPriceCarmethod()
        {
            //Arrange
            var Car = new Car();
            //Act
            double result = Car.Price();
            //Assert
            Assert.AreEqual(240, result);

        }
        [TestMethod]
        public void TestVehicleType()
        {
            //Arrange
            var Car = new Car();
            //Act
            string result = Car.VehicleType();
            //Assert
            Assert.AreEqual("Car", result);

        }
        [TestMethod]
        public void TestPriceMCmethod()
        {
            //Arrange
            var MC = new MC();
            //Act
            double result = MC.Price();
            //Assert
            Assert.AreEqual(125, result);

        }
        [TestMethod]
        public void TestVehicleMCmethod()
        {
            //Arrange
            var MC = new MC();
            //Act
            string result = MC.Vehicle();
            //Assert
            Assert.AreEqual("MC", result);
        }
    }
}
