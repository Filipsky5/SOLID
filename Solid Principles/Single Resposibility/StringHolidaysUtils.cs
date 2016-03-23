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

    class Laugh {
        private string laughSound;
        public Laugh(string sound) {
            laughSound = sound;
        }
        public string generate(int nrOfTimes) {
            return string.Concat(Enumerable.Repeat(laughSound, nrOfTimes));
        }
    }

    class RefCounter {
        private string[] references;
        public RefCounter(params string[] refs) {
            references = refs;
        }
        public int count(string inputString) {
            return references.Sum(r => Regex.Matches(inputString.ToLower(), Regex.Escape(r.ToLower())).Count);
        }
    }
}
