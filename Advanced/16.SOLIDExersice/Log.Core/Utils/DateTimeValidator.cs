using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log.Core.Utils
{
    public static class DateTimeValidator
    {
        private static readonly ISet<string> formats = new HashSet<string>() { "M/dd/yyyy h:mm:ss tt" };
        //each time you add a new format it is going to last until the program ends the execution. A solution could be adding the formats to a file and extracting them each time the program starts
        public static void AddFormat(string format) => formats.Add(format);
        public static bool ValidateDateTimeFormat(string dateTime)

        {
            foreach (var format in formats)
            {


                if (DateTime.TryParseExact(dateTime, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
