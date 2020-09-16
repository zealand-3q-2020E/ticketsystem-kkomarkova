using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{/// <summary>
/// This is class Car (remember to make it public)
/// </summary>
    public class Car : Vehicle
    {
        //Constructor of Car class
       public Car(string plate, DateTime date) : base(plate, date)
        {
            _datetime = date;
            _licensePlate = plate;
        }
        /// <summary>
        /// This is property Licenseplate
        /// </summary>
        //public string Licenseplate { get; set; }
        /// <summary>
        /// This is property DateTime
        /// </summary>
        //public DateTime date { get; set; }
        /// <summary>
        /// This is method Price, which returns value 240
        /// </summary>
        /// <returns></returns>
        public override double Price()
        {
            return 240;
        }
        /// <summary>
        /// This is method VehicleType, which returns type of vehicle "car"
        /// </summary>
        /// <returns></returns>
        public override string VehicleType()
        {
            return "Car";
        }
    }
}
