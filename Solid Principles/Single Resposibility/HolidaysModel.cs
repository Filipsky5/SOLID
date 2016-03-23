using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples
{
    class StringHolidaysUtils
    {
        public string HolidayName { get; private set; }

        public StringHolidaysUtils(string holidayName)
        {
            HolidayName = holidayName;
        }
    }
}
