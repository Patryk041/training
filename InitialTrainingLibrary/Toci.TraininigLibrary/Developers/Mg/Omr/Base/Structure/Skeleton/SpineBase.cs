using System;
using System.Linq;
using Toci.TraininigLibrary.Developers.Mg.Omr.Helpers;

namespace Toci.TraininigLibrary.Developers.Mg.Omr.Base.Structure.Skeleton
{
    public abstract class SpineBase
    {

        protected SpineBase(int cervicalVerbetraeNumber, int thoaricacicNumber, int lumbarNumber, int sacralNumber, int caudalNumber)
        {

            CreateSpine(ref cervicalVerbetraeNumber, ref thoaricacicNumber, ref lumbarNumber, ref sacralNumber, ref caudalNumber);
            TotalNumberOfVertebrae = SpineSegments.Sum(x => x.NumberOfVertebrae);
        }

        public int TotalNumberOfVertebrae { get; private set; }
        public SpineSegment[] SpineSegments { get; private set; }

        //public void CreateSpine(Func<SpineSegment[]> fillingFunc)
        //{
        //    SpineSegments = fillingFunc.Invoke();
        //    TotalNumberOfVertebrae = SpineSegments.Sum(x => x.NumberOfVertebrae);
        //}

        private void CreateSpine(ref int cervicalVerbetraeNumber, ref int thoaricacicNumber, ref int lumbarNumber, ref int sacralNumber, ref int caudalNumber)
        {
            SpineSegments = new SpineSegment[]
            {
                new SpineSegment(){SegmentName = SpineSegmentEnum.Cervical, NumberOfVertebrae = cervicalVerbetraeNumber},
                new SpineSegment(){SegmentName = SpineSegmentEnum.Thoracic, NumberOfVertebrae = thoaricacicNumber},
                new SpineSegment(){SegmentName = SpineSegmentEnum.Lumbar, NumberOfVertebrae = lumbarNumber},
                new SpineSegment(){SegmentName = SpineSegmentEnum.Sacral, NumberOfVertebrae = sacralNumber},
                new SpineSegment(){SegmentName = SpineSegmentEnum.Caudal, NumberOfVertebrae = caudalNumber}
            };
        }



    }
}
