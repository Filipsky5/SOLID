using System;

namespace CleanCode.SolidPrinciples.DependencyInversion
{

    public class Printer:IPrintable
    {
        public void Print(string textToCopy)
        {
            Console.WriteLine(textToCopy);
        }
    }
}