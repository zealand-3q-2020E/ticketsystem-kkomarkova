using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
namespace UnitTestTicketSystem
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPricemethod()
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
    }
}
