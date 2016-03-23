using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples
{
    
    class LaughGenerator
    {
        private int numberOfTimes { private get }
        private string laughSound { private get }
        public LaughGenerator(int numberOfTimes, string laughSound) {
            this.laughSound = numberOfTimes;
            this.laughSound = laughSound;
        }
        
        public generate() {
            return string.Concat(Enumerable.Repeat(this.laughSound, this.numberOfTimes));
        }    
    }
    
    class HolidayCounter {
        private string[] references { private get; }
        public HolidayCounter(string[] references) {
            this.references = references;
        }
        public int count(string holidayName) {
            return this.references.Sum(r => Regex.Matches(holidayName.ToLower(), Regex.Escape(r.ToLower())).Count);
        }
    }
    
    class StringHolidaysUtils
    {
        private string _laughSound;
        private string[] _references;

        public string HolidayName { get; private set; }

        public StringHolidaysUtils(string holidayName, string laugh, params string[] references)
        {
            _laughSound = laugh;
            HolidayName = holidayName;
            _references = references;
        }

        public string GenerateLaugh(int nrOfTimes)
        {
            return string.Concat(Enumerable.Repeat(_laughSound, nrOfTimes));
        }

        public int CountReferences(string inputString)
        {
            return _references.Sum(r => Regex.Matches(inputString.ToLower(), Regex.Escape(r.ToLower())).Count);
        }
    }
}
