using System;
using System.Collections.Generic;
using Toci.TraininigLibrary.Developers.Mg.Omr.Base.Structure.Skeleton;
using Toci.TraininigLibrary.Developers.Mg.Omr.Base.Structure.Skeleton.Spines;

namespace Toci.TraininigLibrary.Developers.Mg.Omr.Helpers
{
    public static class SpineHelperFactory
    {

        public static Dictionary<VertebrataAnimalsNameEnum, Func<SpineBase>> GetProperSpine = new Dictionary
            <VertebrataAnimalsNameEnum, Func<SpineBase>>()
        {
            {VertebrataAnimalsNameEnum.Cow, () => new CowSpine()},
            {VertebrataAnimalsNameEnum.Horse, () => new HorseSpine()},
            {VertebrataAnimalsNameEnum.Pig, () => new PigSpine()}
        };

    }
}
