using System;
using System.IO;

namespace Anathema.Patryk.TrainingTwo.Utils
{
    public class FileOperations
    {
        public string ReadAllContent(string path)
        {
            try
            {
                //klasa StreamReader implementuje IDisposable, więc można ją utworzyć w using()
                //dzięki tem w bloku finally nie trzeba zwalniac zasobow ( w tym przypadku reader.close() )
                using (StreamReader reader = new StreamReader(path))
                {
                    string result = reader.ReadToEnd();
                    return result;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void AppendTextToFile(string text, string path)
        {
            using (FileStream fileStream = new FileStream(path, FileMode.Append))
            {
                using (StreamWriter streamWriter = new StreamWriter(fileStream))
                {
                    streamWriter.WriteLine(text);
                }
            }
        }
    }
}