using System;
namespace CleanCode.SolidPrinciples
{
    public class ObservationPlace
    {
        public string Environment { get; internal set; }
        
        public int LengthOfIngoredSigns()
        {
            string result;
            ConsoleStringWriter(this.EnviromentSound);
            result = this.Environment;
            foreach (var ignored in this.IgnoredCase)
                result = result.Replace(ignored, string.Empty);

            return result.Length;
         
        }
        public void ConsoleStringWriter(string soundOfEnviroment)
        {
            Console.WriteLine(soundOfEnviroment);
        }

        public virtual string[] IgnoredCase
        {
            get
            {
                return new string[0];
            }
        }

        public virtual string EnviromentSound
        {
            get
            {
                return "dupa";
            }
        }
    }

    public class ForestPlace : ObservationPlace
    {
        public override string[] IgnoredCase
        {
            get
            {
                return new string[] { "|", "@" };
            }
        }

        public override string EnviromentSound
        {
            get
            {
                return "<Forest Sounds>";
            }
        }
    }

    public class OceanPlace : ObservationPlace
    {
        public override string[] IgnoredCase
        {
            get
            {
                return new string[] { "~" };
            }
        }

        public override string EnviromentSound
        {
            get
            {
                return "bul bul bul";
            }
        }
    }
}