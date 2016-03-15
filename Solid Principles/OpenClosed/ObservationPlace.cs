using System;
namespace CleanCode.SolidPrinciples
{
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