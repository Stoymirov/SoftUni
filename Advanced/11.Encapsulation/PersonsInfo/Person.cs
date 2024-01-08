using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsInfo
{
    public class Person
    {
        private  string lastName;

        public Person(string first, string last, int age)
      {
          Age = age;
          FirstName = first;
          LastName = last;
      }
      public string FirstName { get; private set; }

      public string LastName { get;private set; }

      public int Age { get; private set; }
      public override string ToString()
      {
          return $"{FirstName} {LastName} is {Age} years old";
      }
    }
}
