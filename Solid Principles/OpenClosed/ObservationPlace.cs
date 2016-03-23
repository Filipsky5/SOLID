using System;
namespace CleanCode.SolidPrinciples
{
    public class Place 
    {
        protected virtual string sound();
        protected virtual string name();
        protected virtual string[] ignoredSigns();
        
        public int LengthOfIngoredSigns()
        {
            string result;
            ConsoleStringWriter(this.sound());
            result = this.name();
            foreach (var ignored in this.ignoredSigns)
                result = result.Replace(ignored, string.Empty);
            return result.Length;
        }
    }
    
    public class Ocean : Place
    {
        protected name() {
            return "ocean";
        }
        
        protected sound() {
            return "bul bul bul";
        }
        
        protected string[] ignoredSigns() {
             return new string[] { "~" };
        }
        
        
    }
    
    public class Forest : Place
    {
        protected name() {
            return "forest";
        }
        
        protected sound() {
            return "<Forest sound>";
        }
        
        protected string[] ignoredSigns() {
            return new string[]{ "|", "@" };
        }
    }
    public class ObservationPlace
    {
        public string Environment { get; internal set; }
        public PlaceType Type { get; internal set; }

        public int LengthOfIngoredSigns(string[] ignoredSigns, string soundOfEnviroment)
        {
            string result;
            if (!Enum.IsDefined(typeof(PlaceType),Type))
            {
                throw new InvalidOperationException("Unknown place");
            }
            ConsoleStringWriter(soundOfEnviroment);
            result = this.Environment;
            foreach (var ignored in ignoredSigns)
                result = result.Replace(ignored, string.Empty);

            return result.Length;
         
        }
        public void ConsoleStringWriter(string soundOfEnviroment)
        {
            Console.WriteLine(soundOfEnviroment);
        }
    }
}