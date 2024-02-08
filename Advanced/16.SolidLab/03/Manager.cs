using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    public class Manager:BaseEmployee
    {
        public Manager(string name, ICollection<string> documents) : base(name)
        {
            this.Documents = new List<string>(documents);
        }

        public IReadOnlyCollection<string> Documents { get; set; }
        public override void Printer()
        {
            Console.WriteLine(Name);
            Console.WriteLine(string.Join(Environment.NewLine,Documents));
        }
    }
}
