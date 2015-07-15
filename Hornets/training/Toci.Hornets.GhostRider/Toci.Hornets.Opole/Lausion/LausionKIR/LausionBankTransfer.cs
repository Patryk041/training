using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Opole.Lausion.LausionKIR
{
    public class LausionBankTransfer:BankTransfer
    {
        public string Recipent { get; set; }
        public string Sender { get; set; }
        public string Title { get; set; }
        public string Date { get; set; }
        public double Amount { get; set; }

         
    }
}