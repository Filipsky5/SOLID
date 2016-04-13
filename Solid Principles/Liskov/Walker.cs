using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples.Liskov
{
    public class Walker
    {
        public virtual void Walk()
        {
            Console.WriteLine("Just walkin'");
        }
    }
}