using System.Collections.Generic;
using System.IO;


namespace Toci.BeginnersTrainingLibrary.TrainingOne.Recha.omr
{
    public static class IO
    {
        public static void Save(List<string> newClass)
        {
            TextWriter tw = new StreamWriter("class.cs");

            foreach (var line in newClass)
            {
                tw.WriteLine(line);
            }
            tw.Close();
        }
    }
}
