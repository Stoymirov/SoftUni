using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    public class CustomExc:Exception
    {
        public  int From = 0;
        public  int To = 10;
        public CustomExc(int from, int to):base($"Input cannot drun {from} drun {to}")
        {
            To = to;
            From = from;
        }
    }
}
