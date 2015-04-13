using System.Drawing;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Recha.omr2
{
    public class BmpFormat : IFilesFormat, IBmpFormat
    {
        public void FileProcessing(string filePath)
        {
            var bmp = OpenFile(filePath);
            bmp.RotateFlip(RotateFlipType.Rotate90FlipNone);
            Save(bmp, filePath);
        }

        public Bitmap OpenFile(string filePath)
        {
            return new Bitmap(@"D:\aaa.bmp");
        }

        public void Save(Bitmap bmp, string filePath)
        {
            bmp.Save(@"D:\bbb.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
        }
    }
}
