using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Runtime.CompilerServices;
using System;

namespace UnitTestTicketSystem
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPriceCarmethod()
        {
            //Arrange
            string licenseplate = "ABC-ITR";
            DateTime datetime = new DateTime(2014, 12, 7);

            var Car = new Car(licenseplate, datetime);
            //Act
            double result = Car.Price();
            //Assert
            Assert.AreEqual(240, result);

        }
        [TestMethod]
        public void TestVehicleType()
        {
            //Arrange
            string licenseplate = "ABC-ITR";
            DateTime datetime = new DateTime(2014, 12, 7);
            var Car = new Car(licenseplate, datetime);
            //Act
            string result = Car.VehicleType();
            //Assert
            Assert.AreEqual("Car", result);

        }
        [TestMethod]
        public void TestPriceMCmethod()
        {
            //Arrange
            string licenseplate = "ABC-ITR";
            DateTime datetime = new DateTime(2014, 12, 7);
            var MC = new MC(licenseplate, datetime);
            //Act
            double result = MC.Price();
            //Assert
            Assert.AreEqual(125, result);

        }
        [TestMethod]
        public void TestVehicleMCmethod()
        {
            //Arrange
            string licenseplate = "ABC-ITR";
            DateTime datetime = new DateTime(2014, 12, 7);
            var MC = new MC(licenseplate, datetime);
            //Act
            string result = MC.VehicleType();
            //Assert
            Assert.AreEqual("MC", result);
        }
    }
}
