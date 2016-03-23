using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples
{
    class StringHolidays
    {
        public string HolidayName { get; private set; }

        public StringHolidays(string holidayName, string laugh, params string[] references)
        {
            HolidayName = holidayName;
        }




    }
}
