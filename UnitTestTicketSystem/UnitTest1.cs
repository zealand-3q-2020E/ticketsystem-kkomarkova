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
            bool brobizz = false;
            int discount = 5;
            bool weekendiscount = false;
            bool Oresundbron = false;

            var Car = new Car(licenseplate, datetime, brobizz, discount, weekendiscount, Oresundbron);            //Act
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
            bool brobizz = true;
            int discount = 5;
            bool weekendiscount = false;
            bool Oresundbron = false;

            var Car = new Car(licenseplate, datetime, brobizz, discount, weekendiscount, Oresundbron);
            
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
            bool brobizz = false;
            int discount = 5;
            bool Oresundbron = false;

            var MC = new MC(licenseplate, datetime, brobizz, discount, Oresundbron);
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
            bool brobizz = true;
            int discount = 5;
            bool Oresundbron = false;

            var MC = new MC(licenseplate, datetime, brobizz, discount, Oresundbron);
            //Act
            string result = MC.VehicleType();
            //Assert
            Assert.AreEqual("MC", result);
        }
        [TestMethod]
        public void TestLicenseplatelenght()
        {
            //Arrange
            string licenseplate = "1234567";
            DateTime datetime = new DateTime(2014, 12, 7);
            bool brobizz = true;
            int discount = 5;
            bool Oresundbron = false;
            //var MC = new MC(licenseplate, datetime);
            //Act
            //string result = MC.VehicleType();
            //Assert
            try
            {
                var MC = new MC(licenseplate, datetime, brobizz, discount, Oresundbron);
            }
            catch (ArgumentException)
            {
                Assert.Fail();
            }

        }
        [TestMethod]
        public void TestBrobizzDiscountMC()

        {
            //Arrange
            string licenseplate = "1234567";
            DateTime datetime = new DateTime(2014, 12, 7);
            bool brobizz = true;
            int discount = 5;
            bool Oresundbron = false;

            var MC = new MC (licenseplate, datetime,brobizz,discount, Oresundbron);
            //Act
            double result = MC.Price();
            //Assert
            Assert.AreEqual(118.5, result, 3);
        }
        [TestMethod]
        public void TestBrobizzDiscountCar()
        {
            //Arrange
            string licenseplate = "1234567";
            DateTime datetime = new DateTime(2014, 12, 7);
            bool brobizz = true;
            int discount = 5;
            bool weekendiscount = false;
            bool Oresundbron = false;
            var Car = new Car(licenseplate, datetime, brobizz, discount, weekendiscount, Oresundbron);
            
            //Act
            double result = Car.Price();
            //Assert
            
            Assert.AreEqual(228, result, 3);
        }
        [TestMethod]
        public void TestWeekendDiscountCar()
        {
            //Arrange
            string licenseplate = "1234567";
            DateTime datetime = new DateTime(2014, 12, 7);
            bool brobizz = true;
            int discount = 5;
            bool weekendiscount = true;
            bool Oresundbron = false;
            var Car = new Car(licenseplate, datetime, brobizz, discount, weekendiscount, Oresundbron);
            //Act
            double result = Car.Price();
            //Assert

            Assert.AreEqual(182, result, 3);
        }
        [TestMethod]
        public void TestOresundDiscountCar()
        {
            //Arrange
            string licenseplate = "1234567";
            DateTime datetime = new DateTime(2014, 12, 7);
            bool brobizz = true;
            int discount = 5;
            bool weekendiscount = false;
            bool Oresundbron = true;
            var Car = new Car(licenseplate, datetime, brobizz, discount, weekendiscount, Oresundbron);
            //Act
            double result = Car.Price();
            //Assert

            Assert.AreEqual(161, result, 3);
        }
        [TestMethod]
        public void TestVehicleOresundMC()
        {
            //Arrange
            string licenseplate = "ABC-ITR";
            DateTime datetime = new DateTime(2014, 12, 7);
            bool brobizz = true;
            int discount = 5;
            bool Oresundbron = true;

            var MC = new MC(licenseplate, datetime, brobizz, discount, Oresundbron);
            //Act
            string result = MC.VehicleType();
            //Assert
            Assert.AreEqual("Oresund MC", result);
        }

    }
 
}
