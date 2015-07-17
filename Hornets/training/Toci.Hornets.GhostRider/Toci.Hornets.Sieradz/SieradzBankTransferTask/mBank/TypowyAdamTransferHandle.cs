using System;
using System.Drawing;
using System.IO;
using Spire.Pdf;
using Spire;
using Spire.Pdf.Graphics;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Sieradz.SieradzBankTransferTask.mBank
{
    public class TypowyAdamTransferHandle :TransferHandle
    {

        public TypowyAdamTransferHandle()
        {
            BankName = "mBank";
        }
        protected override bool Send(BankTransfer transfer)
        {
            GenerateTransferPDF(transfer);
            return true;
        }

        protected bool GenerateTransferPDF(BankTransfer transfer)
        {
            lock (this)
            {
                PdfDocument transferDetails = new PdfDocument();
                //transferDetails.
                System.Drawing.Font pdfFont = new Font("Arial", 18f);
                PdfTrueTypeFont trueTypeFont = new PdfTrueTypeFont(pdfFont, true);

                PdfPageBase TransferPage = transferDetails.Pages.Add();
                PdfBitmap logo = new PdfBitmap(SieradzBankFilesPathHolder.TransferFilesPath + @"..\mBank\logo.jpg");
                TransferPage.Canvas.DrawImage(logo, new RectangleF(new PointF(25.0f, 25.0f), new SizeF(140f, 85f)));
                TransferPage.Canvas.DrawString("\tPotwierdzenie przelewu:", new PdfFont(PdfFontFamily.Helvetica, 20f), new PdfSolidBrush(new PdfRGBColor(0, 0, 0)), 10, 150f);
                TransferPage.Canvas.DrawString(TransferDetailsString(transfer), trueTypeFont, new PdfSolidBrush(new PdfRGBColor(0, 0, 0)), 50, 180f);
                SavePDF(transferDetails);
            }


            return true;
        }

        protected string TransferDetailsString(BankTransfer transfer)
        {
            SieradzBankTransfer extendedTransfer = (SieradzBankTransfer)transfer;
            string[] transferArray = {   "Nr konta nadawcy: "+extendedTransfer.TransferInfo.SourceAccountNumber+"\n", 
                                             "Bank nadawcy: "+extendedTransfer.SourceBank+"\n",
                                             "Adres nadawcy: "+extendedTransfer.TransferInfo.SourcePersonName+"\n",
                                             "Nr konta odbiorcy: "+extendedTransfer.TransferInfo.DestinationAccountNumber+"\n",
                                             "Bank odbiorcy: " + extendedTransfer.DestinationBank+"\n",
                                             "Adres odbiorcy: "+ extendedTransfer.TransferInfo.DestinationPersonName+"\n",
                                             "Kwota przelewu: "+extendedTransfer.TransferInfo.Amount+"zł\n",
                                             "Tytuł przelewu: "+extendedTransfer.TransferInfo.TransferTitle+"\n",
                                             "Data przyjęcia: "+extendedTransfer.TransferInfo.TransferDate+"\n"
                                         };
            string transferDetail = null;
            foreach (var label in transferArray)
            {
                transferDetail += label;
            }
            return transferDetail;
        }

        protected bool SavePDF(PdfDocument transferDetails)
        {
            if (File.Exists(Path.Combine(SieradzBankFilesPathHolder.TransferFilesPath, @"..\mBank\Transfers1.pdf")))
            {
                File.Open(Path.Combine(SieradzBankFilesPathHolder.TransferFilesPath, @"..\mBank\Transfers1.pdf"), FileMode.Open).Close();
                File.Delete(Path.Combine(SieradzBankFilesPathHolder.TransferFilesPath, @"..\mBank\Transfers1.pdf"));
            }
            transferDetails.SaveToFile(SieradzBankFilesPathHolder.TransferFilesPath + @"..\mBank\Transfers1.pdf",FileFormat.PDF);
            transferDetails.Close();

            return File.Exists(SieradzBankFilesPathHolder.TransferFilesPath + @"..\mBank\Transfers1.pdf");
        }

    }
}