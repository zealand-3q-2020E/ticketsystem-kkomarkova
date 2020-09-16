using System;

namespace ClassLibrary
{
    public abstract class Vehicle
    {
        //Constructor base class Vehicle
        public Vehicle (string licenseplate, DateTime datetime)
        {
            LicensePlate = licenseplate;
            Datetime = datetime;
        }

        //Property LicensePlate
        private string licenseplate;

        public string LicensePlate
        {
            get { return licenseplate; }
            set { licenseplate = value; }
        }

        //Property DateTime
        private DateTime datetime;

        public DateTime Datetime
        {
            get { return datetime; }
            set { datetime = value; }
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
