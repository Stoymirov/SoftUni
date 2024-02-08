using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    public class DetailsPrinter
    {
        private IList<BaseEmployee> employees;

        public DetailsPrinter(IList<BaseEmployee> employees)
        {
            this.employees = employees;
        }

        public void PrintDetails()
        {
            foreach (BaseEmployee employee in this.employees)
            {
                employee.Printer();
            }
        }

    }
}
