using System;
using System.ComponentModel.DataAnnotations;

namespace ClassLibrary
{
    public class Vehicle
    {
        public bool Brobizz;
        private string plate;
        private DateTime date;
        private int Discount;
        private string vehicleName;
        private double price;




        //Constructor base class Vehicle
        public Vehicle (string licenseplate, DateTime datetime, bool brobizz, int discount)
        {
            plate = licenseplate;
            date = datetime;
            Brobizz = brobizz;
            Discount = discount;

        }

        /// <summary>
        /// Property LicensePlate, if the licenseplate is longer than 7 characters the exception is thrown
        /// </summary>
        protected string _licensePlate
            
        {
            get { return plate; }
            set {
                if (plate.Length > 7)
                    throw new ArgumentException("The License plate is not in right format, please try it again");

                else plate = value; }
        }
        
        /// <summary>
        /// Property Discount
        /// </summary>
        public int _Discount
        {
            get { return Discount; }
            set { Discount = value; }
        }




        /// <summary>
        ///Property DateTime
        /// </summary>
        protected DateTime _datetime
        {
            get { return date; }
            set { date = value; }
        }
        
        /// <summary>
        /// Property Brobizz
        /// </summary>
        protected bool _brobbiz
        {
            get { return Brobizz; }
            set { 
                Brobizz = value; }
        }


        /// <summary>
        /// Methods of base class Price, VehicleType..
        /// </summary>
        /// <returns></returns>
        public virtual double Price()
        {
            if (Brobizz == true)
                price = price - (price * 5 / 100);
            else
            {

            }
            return price;
        }

        public virtual string VehicleType()
        {
            return vehicleName;
        }

        public override string ToString()
        {
            return VehicleType();
        }
    }
}
