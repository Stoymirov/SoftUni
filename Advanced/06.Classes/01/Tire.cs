﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    internal class Tire
    {
        private int year;
        private double pressure;

        public Tire(int year, double pressure)
        {
			Year = year;
			this.Pressure = pressure;
        }
		public int Year
		{
			get { return year; }
			set { year = value; }
		}

		public double Pressure
		{
			get { return pressure; }
			set { pressure = value; }
		}


	}
}
