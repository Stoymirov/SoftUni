using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log.Core.Exceptions
{
    public class EmptyCreatedTextException:Exception
    {
        private const string DefaultMessage = "Message text cannot be white space or null";
        public EmptyCreatedTextException():base(DefaultMessage) { }
        public EmptyCreatedTextException(string message):base(message) { }

    }
}
