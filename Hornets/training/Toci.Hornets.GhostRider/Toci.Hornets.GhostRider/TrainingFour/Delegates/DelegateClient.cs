using System;
using Toci.Hornets.GhostRider.GhostRider;
using Toci.Hornets.GhostRider.Kir;
using Toci.Hornets.GhostRider.TrainingFour.ExtensionMethods;

namespace Toci.Hornets.GhostRider.TrainingFour.Delegates
{
    public class DelegateClient
    {
        public DelegateExamples.Whatever GetDelegatesStack()
        {
            DelegateExamples.Whatever del;

            DelegateExamples ex  = new DelegateExamples();

            //MyExampleOfHomework transfers = new MyExampleOfHomework();

            //ex.Delegowanie("fdsafda");

            del = ex.Delegowanie;
            del = (strItem, transf) => Patrzcie(transf);

            //transfers.RunMeAsDelegate("fdsg");

            //del += transfers.RunMeAsDelegate;

            return del; // 0
        }

        public void InjectDelegate(DelegateExamples.Whatever delWhatever)
        {

            delWhatever("fds", null);
        }

        private bool Patrzcie(PerformTransfers fdas)
        {
            fdas.TransferAll();

            return true;
        }
    }
}