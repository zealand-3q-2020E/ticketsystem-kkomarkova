using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    /// <summary>
    /// This is class MC (remember to make it public)
    /// </summary>
    public class MC : Vehicle
    {
        //Constructor of MC class 
       public MC(string plate, DateTime date) : base(plate, date)
        {
            _datetime = date;
            _licensePlate = plate;
        }
        /// <summary>
        /// Class MC has Property Licenseplate
        /// </summary>
        // public string Licenseplate { get; set; }
        /// <summary>
        /// Class Mc has Property date
        /// </summary>
        // public DateTime date { get; set; }
        /// <summary>
        /// This is double method Price, the value returned is fixed at 125 kr
        /// </summary>
        /// <returns></returns>
        public override double Price()
        {
            return 125;
        }
        /// <summary>
        /// This is  string method Vehicle, the value returned is "MC"
        /// </summary>
        /// <returns></returns>
        public override string VehicleType()
        {
            return "MC";
        }

        

    }
}
