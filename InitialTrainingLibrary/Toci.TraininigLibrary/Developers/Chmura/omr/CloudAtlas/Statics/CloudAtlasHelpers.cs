using System;
using System.Collections.Generic;
using System.Linq;
using Toci.TraininigLibrary.Developers.Chmura.omr.CloudAtlas.Abstract;
using Toci.TraininigLibrary.Developers.Chmura.omr.CloudAtlas.Concrete;

namespace Toci.TraininigLibrary.Developers.Chmura.omr.CloudAtlas.Statics
{
    public class CloudAtlasHelpers
    {
        public static CloudHeightTypes ComputeHeightType(int height, CloudOccurances occurance)
        {
            switch (occurance)
            {
                case CloudOccurances.Polar:
                    return height < 2
                        ? CloudHeightTypes.Low
                        : height < 4 ? CloudHeightTypes.Medium : CloudHeightTypes.High;
                case CloudOccurances.Moderate:
                    return height < 2
                        ? CloudHeightTypes.Low
                        : height < 8 ? CloudHeightTypes.Medium : CloudHeightTypes.High;
                case CloudOccurances.Tropical:
                    return height < 2
                        ? CloudHeightTypes.Low
                        : height < 9 ? CloudHeightTypes.Medium : CloudHeightTypes.High;
                default:
                    return CloudHeightTypes.High;
            }
        }
    }
}