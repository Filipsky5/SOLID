using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Solid_Principles.Single_Resposibility
{
    class Laugh
    {
        private int _nrOfTimes; 
        private string _laughSound;

        public Laugh(string laughSound)
        {
            _laughSound = laughSound;
        }

        public string GenerateLaugh()
        {
            return string.Concat(Enumerable.Repeat(_laughSound, _nrOfTimes));
        }



    }
}
