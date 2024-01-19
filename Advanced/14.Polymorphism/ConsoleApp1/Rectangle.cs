using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle:Shape
    {
        private double length;

        private double height;

        public Rectangle(double length,double height)
        {
            Length = length;
            Height = height;
        }
        public double Length
        {
            get { return length; }
            private set { length = value; }
        }

        public double Height
        {
            get { return height; }
            private set { height = value; }
        }
        public override double CalculatePerimeter()
        {
            return 2 * (Height + Length);
        }

        public override double CalculateArea()
        {
           return Height *Length;
        }
    }
}
