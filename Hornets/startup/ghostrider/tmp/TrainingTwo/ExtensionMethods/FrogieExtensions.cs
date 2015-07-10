namespace Toci.Hornets.GhostRider.TrainingTwo.ExtensionMethods
{
    public static class FrogieExtensions
    {
        public static IFrogie BeExtensive(this IFrogie obj)
        {
            obj.BeGentle();
            //obj.InvisibleInExtMEthod();

            return null;
        }

        public static T WhateverFrogie<T>(this T obj) where T : IFrogie
        {
            obj.BeExtensive();
            return default(T);
        }
    }
}