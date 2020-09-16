using System;
using System.ComponentModel.DataAnnotations;

namespace ClassLibrary
{
    public class Vehicle
    {
        private string plate;
        private DateTime date;

        //Constructor base class Vehicle
        public Vehicle (string licenseplate, DateTime datetime)
        {
            plate = licenseplate;
            date = datetime;
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

        //Property DateTime
     

        protected DateTime _datetime
        {
            get { return date; }
            set { date = value; }
        }



        private string vehicleName;
        private double price;

        //Methods of base class
        public virtual double Price()
        {
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
