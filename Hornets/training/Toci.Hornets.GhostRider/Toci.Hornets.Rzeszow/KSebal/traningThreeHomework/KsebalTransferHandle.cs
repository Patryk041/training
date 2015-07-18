using System.IO;
using System.Runtime.CompilerServices;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Rzeszow.KSebal.traningThreeHomework
{
    public class KsebalTransferHandle:TransferHandle
    {


       public KsebalTransferHandle()
       {
           BankName = "SuperBank";
       }
        
        //private string path =
          
        protected override bool Send(BankTransfer transfer)
        {   
           // FindFile();
            StreamWriter sw;
            KsebalBankTransfer tr =(KsebalBankTransfer) transfer;
            
                
            if (File.Exists(UserPath.find()+"\\raport.txt"))
                using ( sw = File.AppendText(UserPath.find()+"\\raport.txt"))
                {
                    sw.WriteLine(tr.SenderTransferSurname + " to " + tr.ConsumerTransferSurname);
                    sw.Close();
                    tr.IsTransferSuccessful = true;

                }

            else
            {   sw = new StreamWriter(UserPath.find()+"\\raport.txt");
            sw.WriteLine(tr.SenderTransferSurname + " to " + tr.ConsumerTransferSurname);
                sw.Close();
                tr.IsTransferSuccessful = true;
            }
            return true;

        }

    }
}