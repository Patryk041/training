using System.Collections.Generic;

namespace Toci.Front.Samples.Models
{
    public class HomeModel //: 
    {
        public string WelcomeTextTag { get; set; } 
        public int Krotnosc { get; set; }

        // do kalsy bazowej
        public List<string> ErrMsg { get; set; }
    }
}