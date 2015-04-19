using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingFour.Disposables
{
    public class FileFetcher
    {
        //DisposableList<string> transferContent = new DisposableList<string>();

        int counter = 0;

        public void FetchFiles(string path)
        {
            var files = Directory.GetFiles(path);

            for (int i = 0; i < 10; i++)
            {
                files.AsParallel().WithDegreeOfParallelism(4).ForAll(ReadFileToMemory);
            }

            /*foreach (var file in files)
            {
                StreamReader str = new StreamReader(file);


                transferContent.Add(str.ReadToEnd());
                counter ++;
                Debug.WriteLine("Ilość obejść: {0}", counter);
            }*/

        }

        //DisposableList<string> disposableList = new DisposableList<string>();

        public DisposableList<DisposableList<string>> test = new DisposableList<DisposableList<string>>(); 

        private void ReadFileToMemory(string singleFilePath)
        {
            StreamReader str = new StreamReader(singleFilePath);

           // transferContent.Add(str.ReadToEnd());

            using (var disposableList = new DisposableList<string>())
            {

                while (!str.EndOfStream)
                {
                    disposableList.Add(str.ReadLine());
                }

                counter++;

                test.Add(disposableList);

                Debug.WriteLine("Ilość obejść: {0}, {1}", counter, disposableList.Count);

                str.Close();
            }

            using (StreamWriter swr = new StreamWriter(singleFilePath))
            //StreamWriter swr = new StreamWriter(singleFilePath);

            {
                swr.WriteLine("Dupa");
                //swr.Close();
            }
            


        }


    }
}
