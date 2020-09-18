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
       public MC(string plate, DateTime date, bool Brobizz, int Discount) : base(plate, date, Brobizz, Discount)
        {
            _datetime = date;
            _licensePlate = plate;
            _brobbiz = Brobizz;
            _Discount = Discount;
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
        /// This is double method Price, the value returned is fixed at 125 kr and also if Brobizz is used the discount is calculated
        /// </summary>
        /// <returns></returns>
        private int price = 125;
        public override double Price()
        {
            if (Brobizz == true)
                price = price - (price*5/100);
            else
            {

            }
            return price;
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
