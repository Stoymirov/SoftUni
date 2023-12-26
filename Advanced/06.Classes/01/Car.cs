using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;
using _01;

namespace CarManufacturer
{
     class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelConsumption;
        private double fuelQunatity;
        private Engine engine;
        private Tire[] tires;

        public Car()
        {
            Make = "VW";
            Model = "Golf";
            Year = 2025;
            FuelQunatity = 200;
            FuelConsumption = 10;
        }
        public Car (string make, string model, int year): this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        public Car(string make, string model, int year, double fuelConsumption, double fuelQuantity) : this(make, model,
            year)
        {
            FuelConsumption = fuelConsumption;
            FuelQunatity = fuelQuantity;
        }

        public Car(string make, string model, int year, double fuelConsumption, double fuelQuantity, Engine engine,
            Tire[] tires) : this(make, model, year, fuelConsumption, fuelQuantity)
        {
            Engine = engine;
            Tires = tires;
        }
        public string Make { get { return make; } set { make = value; } }
        public string Model { get { return model; } set { model = value; } }
        public int Year { get { return year; } set { year = value; } }
        public double FuelConsumption { get { return fuelConsumption; } set { fuelConsumption = value; } }

        public double FuelQunatity { get { return fuelQunatity; } set { fuelQunatity = value; } }
        public Engine Engine { get { return engine; } set { engine = value; } }
        public Tire[] Tires { get { return tires; } set { tires = value; } }
        public void Drive(double distance)
        {

            if (this.FuelQunatity - distance * this.FuelConsumption >= 0)
            {
                this.FuelQunatity -= distance * this.FuelConsumption;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmI()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"Make: {this.Make}");
            result.AppendLine($"Model: {this.Model}");
            result.AppendLine($"Year: {this.Year}");
            result.AppendLine($"Fuel: {this.FuelQunatity:f2}");
            return result.ToString();
        }
    }

   












}