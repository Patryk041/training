using System.Drawing;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Recha.omr2
{

    public class BmpFormat : IFilesFormat, IBmpFormat
    {
        public void FileProcessing(string filePath)
    public class BmpFormat : IFilesFormat
    {
        public List<string> SetFileNames()
        {
            var bmp = OpenFile(filePath);
            bmp.RotateFlip(RotateFlipType.Rotate90FlipNone);
            Save(bmp, filePath);
        }


        public Bitmap OpenFile(string filePath)

        public void OpenFile(string extractPath)
        {
            return new Bitmap(@"D:\aaa.bmp");
        }


        public void Save(Bitmap bmp, string filePath)

        public void SaveFile(string filePath, string fileName)
        {
            throw new NotImplementedException();
        }

        public void FileProcessing(string filePath)
        {
            bmp.Save(@"D:\bbb.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
        }
    }
}
