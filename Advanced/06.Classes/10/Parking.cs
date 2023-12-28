﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniParking
{
    public class Parking
    {
        private Dictionary<string, Car> cars;
        private int capacity;
        public Parking(int capacity)
        {
            cars = new();
            this.capacity = capacity;
        }

        public int Count
        {
            get { return cars.Count; }
        }

        public string AddCar(Car car)
        {
            if (cars.ContainsKey(car.RegistrationNumber))
            {
                return ("Car with that registration number, already exists!");
            }
            else if (cars.Count >= capacity)
            {
                return ("Parking is full!");
            }
            else
            {
                cars.Add(car.RegistrationNumber, car);
                return ($"Successfully added new car {car.Make} {car.RegistrationNumber}");
            }
        }

        public string RemoveCar(string registrationNumber)
        {
            if (!cars.ContainsKey(registrationNumber))
            {
                return ("Car with that registration number, doesn't exist!");
            }


            cars.Remove(registrationNumber);
            return ($"Successfully removed {registrationNumber}");

        }

        public Car GetCar(string registrationNumber)
        {
            return cars[registrationNumber];
        }

        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            foreach (var registrationNumber in registrationNumbers)
            {
                RemoveCar(registrationNumber);
            }
        }
    }
}
