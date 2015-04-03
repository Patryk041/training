using System.Collections.Generic;
using System.IO;


namespace Toci.BeginnersTrainingLibrary.TrainingOne.Recha.omr
{
    public class Io
    {
        public virtual void Save(List<string> newClass, string fileName)
        {
            TextWriter tw = new StreamWriter(fileName);

            foreach (var line in newClass)
            {
                tw.WriteLine(line);
            }
            tw.Close();
        }
    }
}
