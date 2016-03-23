using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles.Single_Resposibility
{
    class Laugh
    {
        private string laughSound;

        public Laugh(string laugh)
        {
            laughSound = laugh;
        }

        public string GenerateLaugh(int nrOfTimes)
        {
            return string.Concat(Enumerable.Repeat(laughSound, nrOfTimes));
        }
    }
}
