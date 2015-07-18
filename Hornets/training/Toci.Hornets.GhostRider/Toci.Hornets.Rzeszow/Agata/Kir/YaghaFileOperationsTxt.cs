namespace Toci.Hornets.Rzeszow.Agata.Kir
{
    public class YaghaFileOperationsTxt : Toci.Hornets.GhostRider.Kir.FileOperation
    {
        public override string GetFileContent(string path)
        {
            string TransferData=null,line;
            System.IO.StreamReader file = new System.IO.StreamReader(path);
            while ((line = file.ReadLine()) != null)
            {
                TransferData += line;
            }
            file.Close();
            return TransferData;
        }
    }
}