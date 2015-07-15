using System;
using System.IO;
using Spire.Pdf;
using Spire;
using Spire.Pdf.Graphics;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Sieradz.SieradzBankTransferTask.mBank
{
    public class TypowyAdamTransferHandle :TransferHandle
    {
        
        protected override bool Send(BankTransfer transfer)
        {
            PdfDocument transferDetails = new PdfDocument();
            PdfPageBase TransferPage = transferDetails.Pages.Add();
            TransferPage.Canvas.DrawString("mBank\n\t\tPotwierdzenie przelewu:", new PdfFont(PdfFontFamily.Helvetica, 30f),new PdfSolidBrush(new PdfRGBColor(0,0,0)), 10,10  );
            if (File.Exists(Path.Combine(SieradzBankFilesPathHolder.TransferFilesPath, @"..\mBank\Transfers1.pdf")))
            {
              //  File.Open(Path.Combine(SieradzBankFilesPathHolder.TransferFilesPath, @"..\mBank\Transfers1.pdf"),FileMode.Open).Close();
                File.Delete(Path.Combine(SieradzBankFilesPathHolder.TransferFilesPath, @"..\mBank\Transfers1.pdf"));
            }
            transferDetails.SaveToFile(SieradzBankFilesPathHolder.TransferFilesPath+@"..\mBank\Transfers1.pdf");
            transferDetails.Close();
            //throw new System.NotImplementedException();
            return true;
        }

        public bool SendTransfer(BankTransfer transfer)
        {
            Send(transfer);
            return true;
        }
    }
}