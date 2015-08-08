using System;

namespace Toci.Hornets.GhostRider.TrainingSeven.Attributes
{
    [Flags]
    public enum SimpleFlaggedEnum
    {
        // 1000 1001 1011
        Private = 1,
        Instance = 2,
        Public = 4,
        PrivateInstancePublic = Private | Instance | Public,
        Static = 8

    }
}