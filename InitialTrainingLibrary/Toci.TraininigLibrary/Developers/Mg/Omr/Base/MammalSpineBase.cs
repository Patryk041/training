

using System;
using System.Linq;
using Toci.TraininigLibrary.Developers.Mg.Omr.Helpers;

namespace Toci.TraininigLibrary.Developers.Mg.Omr.Base
{
    public abstract class MammalSpineBase : SpineBase
    {
        
        protected MammalSpineBase(int thoaricacicNumber, int lumbarNumber, int sacralNumber, int caudalNumber)
            : base(7,thoaricacicNumber, lumbarNumber, sacralNumber, caudalNumber)
        {

            FillSpineSegments(FillMammalSegments);

        }


        private SpineSegment[] FillMammalSegments()
        {
            return new SpineSegment[]
            {
                SpineHelperFactory.GetSpineSegment[SpineSegmentEnum.Cervical](CervicalVerbetraeNumber),
                SpineHelperFactory.GetSpineSegment[SpineSegmentEnum.Thoracic](ThoaracicVerbetraeNumber),
                SpineHelperFactory.GetSpineSegment[SpineSegmentEnum.Lumbar](LumbarVerbetraeNumber),
                SpineHelperFactory.GetSpineSegment[SpineSegmentEnum.Sacral](SacralVerbetraeNumber),
                SpineHelperFactory.GetSpineSegment[SpineSegmentEnum.Caudal](CaudalVerbetraeNumber),
            };
        }

     
    }
}
