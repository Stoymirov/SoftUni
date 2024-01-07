﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public abstract class Animal
    {
        private string _name;
        private int _age;
        private string _gender;
        protected Animal(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;

        }

        public string Name
        {
            get => _name;

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Invalid input!");
                }
                _name = value;
            }
        }

        public int Age
        {
            get => _age;

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Invalid input!");
                }
                _age = value;
            }
        }
        public string Gender
        {
            get => _gender;

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Invalid input!");
                }
                _gender = value;
            }
        }

        public abstract string ProduceSound();
        public override string ToString()
        {
            return $"{GetType().Name}{Environment.NewLine}{Name} {Age} {Gender}{Environment.NewLine}{ProduceSound()}";
        }
    }
}
