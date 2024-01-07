using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Person
    {
        private int age;
        public Person(string name, int age)
        {

            Name = name;  
            Age = age;
        }

        public virtual int Age
        {
            get => age;
            init
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid age");
                }
                age = value; 
            }
        }

        public string Name { get; private set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Name: {Name}, Age: {Age}");
            return sb.ToString().TrimEnd();
        }
    }
}
