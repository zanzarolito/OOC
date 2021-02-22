using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingProblem.Models
{
    class Car
    {
        public int hours { get; set; }


        public Car(int _hours)
        {
            hours = _hours;
        }

        public double Charges()
        {
            if (hours >= 24)
                return 10;
            if (hours <= 3)
                return 2;
            else
                return 2 + (hours - 3) * 0.5;
        }


    }
}
