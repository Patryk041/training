    using System;
    using System.IO;
        namespace Toci.Hornets.BankFactory
{
    public class FileReader
    {
            public string ReadAllContent(string path)
            {
                try
                {
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

