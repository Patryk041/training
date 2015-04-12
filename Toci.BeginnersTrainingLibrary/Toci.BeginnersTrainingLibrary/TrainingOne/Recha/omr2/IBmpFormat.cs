using System.Drawing;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Recha.omr2
{
    interface IBmpFormat
    {
        Bitmap OpenFile(string filePath);

        void Save(Bitmap bmp, string filePath);
    }
}
