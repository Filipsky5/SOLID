using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples.Liskov
{
    class TexasRanger : Walker
    {
        public void DoRoundHouseKick()
        {
            Console.WriteLine("Hyiaa!");
        }

        public override void Walk()
        {
            throw new Exception("Chuck Norris doesn't walk - the earth moves beneath him");
        }
    }
}