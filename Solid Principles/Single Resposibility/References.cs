using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Solid_Principles.Single_Resposibility
{
    class References
    {
        private string[] _references;

        public References(string[] refs)
        {
            _references = refs;
        }
        public int CountReferences(string inputString)
        {
            return _references.Sum(r => Regex.Matches(inputString.ToLower(), Regex.Escape(r.ToLower())).Count);
        }

    }
}
