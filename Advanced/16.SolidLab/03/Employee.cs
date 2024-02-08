using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    public class Employee:BaseEmployee
    {
        public Employee(string name):base(name)
        {
            this.Name = name;
        }
        public string Name { get; }
        public override void Printer()
        {
            Console.WriteLine(Name);
        }
    }
}
