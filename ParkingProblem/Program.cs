using System;
using ParkingProblem.Models;
using System.Collections.Generic;

namespace ParkingProblem
{
    class Program
    {
        static double TotalCharges(List<Car> Garage)
        {
            double Receipt = 0;
            int i = 0;

            while(i < Garage.Count)
            {
                Receipt += Garage[i].Charges();
                i++;
            }
                 

            return Receipt;
        }
        static void Main(string[] args)
        {
            double Price = 0;

            
            
            ;

            List<Car> Garage = new List<Car>();


            Car Lambo = new Car(5);
            Car Ferrari = new Car(10);
            Car Ford = new Car(2);
            Car Fiat = new Car(7);


            Garage.Add(Lambo);
            Garage.Add(Ferrari);
            Garage.Add(Ford);
            Garage.Add(Fiat);

            double receipt = TotalCharges(Garage);


            Console.WriteLine("Receipt of the day : {0} euro(s)", receipt);
        }
    }
}
