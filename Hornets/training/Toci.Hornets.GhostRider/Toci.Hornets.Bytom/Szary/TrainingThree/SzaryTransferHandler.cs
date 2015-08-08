using System.IO;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Bytom.Szary.TrainingThree
{
    public class SzaryTransferHandler:TransferHandle
    {
        public SzaryTransferHandler()
       {
           BankName = "SuperBank";
       }
        
        //private string path =
          
        protected override bool Send(BankTransfer transfer)
        {   
           // FindFile();
            StreamWriter sw;
            SzaryBankTransfer tr =(SzaryBankTransfer) transfer;
            
                
         /*   if (File.Exists(UserPath.Find()+"\\raport.txt"))
                using ( sw = File.AppendText(UserPath.Find()+"\\raport.txt"))
                {
                    sw.WriteLine(tr.SenderTransferSurname + " to " + tr.ConsumerTransferSurname);
                    sw.Close();
                    tr.IsTransferSuccessful = true;

                }

            else
            {   sw = new StreamWriter(UserPath.Find()+"\\raport.txt");
            sw.WriteLine(tr.SenderTransferSurname + " to " + tr.ConsumerTransferSurname);
                sw.Close();
                tr.IsTransferSuccessful = true;
            }*/
            //Sa ERRORY! DO POPRAWKI
            return true;

        }
    }
}