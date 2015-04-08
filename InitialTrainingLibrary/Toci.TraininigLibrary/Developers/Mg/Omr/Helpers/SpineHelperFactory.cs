using System;
using System.Collections.Generic;
using System.Linq;

using Toci.TraininigLibrary.Developers.Mg.Omr.Base;
using Toci.TraininigLibrary.Developers.Mg.Omr.Spines;

namespace Toci.TraininigLibrary.Developers.Mg.Omr.Helpers
{
    public static class SpineHelperFactory
    {

        public static Dictionary<VertebraeAnimalsNameEnum, Func<MammalSpineBase>> GetProperSpine = new Dictionary
            <VertebraeAnimalsNameEnum, Func<MammalSpineBase>>()
        {
            {VertebraeAnimalsNameEnum.Cow, () => new CowSpine()},
            {VertebraeAnimalsNameEnum.Horse, () => new HorseSpine()},
            {VertebraeAnimalsNameEnum.Pig, () => new PigSpine()}
        };

        public static Dictionary<SpineSegmentEnum, Func<int, SpineSegment>> GetSpineSegment = new Dictionary<SpineSegmentEnum, Func<int, SpineSegment>>()
        {
            {SpineSegmentEnum.Cervical,  vertebraeNumber=>new SpineSegment(){NumberOfVertebrae = vertebraeNumber,SegmentName = SpineSegmentEnum.Cervical}},
            {SpineSegmentEnum.Thoracic,  vertebraeNumber=>new SpineSegment(){NumberOfVertebrae = vertebraeNumber,SegmentName = SpineSegmentEnum.Thoracic}},
            {SpineSegmentEnum.Lumbar,  vertebraeNumber=>new SpineSegment(){NumberOfVertebrae = vertebraeNumber,SegmentName = SpineSegmentEnum.Lumbar}},
            {SpineSegmentEnum.Sacral,  vertebraeNumber=>new SpineSegment(){NumberOfVertebrae = vertebraeNumber,SegmentName = SpineSegmentEnum.Sacral}},
            {SpineSegmentEnum.Caudal,  vertebraeNumber=>new SpineSegment(){NumberOfVertebrae = vertebraeNumber,SegmentName = SpineSegmentEnum.Caudal}},
   
        };


 

    }
}
