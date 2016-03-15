using System.Collections.Generic;
namespace CleanCode.SolidPrinciples
{
    public enum PlaceType
    {
        Forest,
        Ocean
    }

    public static class InputData{
        public static Dictionary<PlaceType, string[]> ignoredCase = new Dictionary<PlaceType, string[]> {
            {PlaceType.Forest,new string[]{ "|", "@" }},{PlaceType.Ocean, new string[] { "~" }}
        };
        public static Dictionary<PlaceType, string> enviromentSounds = new Dictionary<PlaceType, string> {
            {PlaceType.Forest,"<Forest Sounds>"},{PlaceType.Ocean, "bul bul bul"}
        };


}
    
     

    
}