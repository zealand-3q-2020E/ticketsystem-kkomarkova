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

        //Property LicensePlate
       

        protected string _licensePlate
            
        {
            get { return plate; }
            set {
                if (plate.Length > 7)
                    throw new ArgumentException("The License plate is not in right format, please try it again");

                else plate = value; }
        }
        

        public int _Discount
        {
            get { return Discount; }
            set { Discount = value; }
        }


        //Property DateTime


        protected DateTime _datetime
        {
            get { return date; }
            set { date = value; }
        }
        

        protected bool _brobbiz
        {
            get { return Brobizz; }
            set { 
                Brobizz = value; }
        }
        

        //Methods of base class
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
