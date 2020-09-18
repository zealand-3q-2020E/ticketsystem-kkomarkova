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
       public Car(string plate, DateTime date, bool Brobizz, int Discount, bool WeekendDiscount) : base(plate, date, Brobizz, Discount)
        {
            _datetime = date;
            _licensePlate = plate;
            _brobbiz = Brobizz;
            _Discount = Discount;
            _weekendDiscount = WeekendDiscount;

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
        /// This is method Price, which returns value 240 and also if Brobizz is used the discount is calculated
        /// </summary>
        /// <returns></returns>
        private int price = 240;
        private int priceafterweekendiscount = 240 - (240 * 20 / 100);
        
        public override double Price()
        {
            if (Brobizz == true && WeekendDiscount == false)
                
            {
                price = price - (price * 5 / 100);
            }
           
            else if(Brobizz == false && WeekendDiscount == true)
            {
                price = price - (price * 20 / 100);
            }
            else if(Brobizz ==true && WeekendDiscount == true)
            {
                price = priceafterweekendiscount - (priceafterweekendiscount * 5 / 100);
            }
            else if (Brobizz ==false && WeekendDiscount == false)
            {
                
            }
            return price;
            
        }

        /// <summary>
        /// This is method VehicleType, which returns type of vehicle "car"
        /// </summary>
        /// <returns></returns>
        public override string VehicleType()
        {
            return "Car";
        }

        private bool _weekendDiscount;

        public bool WeekendDiscount
        {
            get { return _weekendDiscount; }
            set { _weekendDiscount = value; }
        }

    }
}
