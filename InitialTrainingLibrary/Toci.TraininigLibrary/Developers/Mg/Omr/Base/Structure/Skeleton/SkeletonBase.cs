namespace Toci.TraininigLibrary.Developers.Mg.Omr.Base.Structure.Skeleton
{
    public abstract class SkeletonBase
    {
        protected SkeletonBase(SpineBase spine)
        {
            this.Spine = spine;
        }
        public SpineBase Spine { get; protected set;}
    }
}
