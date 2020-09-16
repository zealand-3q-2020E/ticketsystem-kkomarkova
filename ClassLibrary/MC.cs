using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    /// <summary>
    /// This is class MC (remember to make it public)
    /// </summary>
    public class MC
    {
        /// <summary>
        /// Class MC has Property Licenseplate
        /// </summary>
        public string Licenseplate { get; set; }
        /// <summary>
        /// Class Mc has Property date
        /// </summary>
        public DateTime date { get; set; }
        /// <summary>
        /// This is double method Price, the value returned is fixed at 125 kr
        /// </summary>
        /// <returns></returns>
        public double Price()
        {
            return 125;
        }
        /// <summary>
        /// This is  string method Vehicle, the value returned is "MC"
        /// </summary>
        /// <returns></returns>
        public string Vehicle()
        {
            return "MC";
        }

    }
}
