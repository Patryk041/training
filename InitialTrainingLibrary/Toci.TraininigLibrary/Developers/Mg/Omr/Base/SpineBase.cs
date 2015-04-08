using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Developers.Mg.Omr.Helpers;

namespace Toci.TraininigLibrary.Developers.Mg.Omr.Base
{
    public abstract class SpineBase
    {
        protected readonly int CervicalVerbetraeNumber;
        protected readonly int ThoaracicVerbetraeNumber;
        protected readonly int LumbarVerbetraeNumber;
        protected readonly int SacralVerbetraeNumber;
        protected readonly int CaudalVerbetraeNumber;

        protected SpineBase(int cervicalVerbetraeNumber, int thoaricacicNumber, int lumbarNumber, int sacralNumber, int caudalNumber)
        {
            this.CervicalVerbetraeNumber = cervicalVerbetraeNumber;
            this.ThoaracicVerbetraeNumber = thoaricacicNumber;
            this.LumbarVerbetraeNumber = lumbarNumber;
            this.SacralVerbetraeNumber = sacralNumber;
            this.CaudalVerbetraeNumber = caudalNumber;
        }

        public int TotalNumberOfVertebrae { get; private set; }
        public SpineSegment[] SpineSegments { get; private set; }

        protected void FillSpineSegments(Func<SpineSegment[]> fillingFunc)
        {
            SpineSegments = fillingFunc.Invoke();
            TotalNumberOfVertebrae = SpineSegments.Sum(x => x.NumberOfVertebrae);
        }



    }
}
