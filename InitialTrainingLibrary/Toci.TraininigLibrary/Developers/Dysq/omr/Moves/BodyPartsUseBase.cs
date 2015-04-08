namespace Toci.TraininigLibrary.Developers.Dysq.omr.Moves
{
    public abstract class BodyPartsUseBase
    {
        protected bool HeadTouch = false;
        protected bool RightHandTouch = false;
        protected bool LeftHandTouch = false;
        protected bool RightLegTouch = false;
        protected bool LeftLegTouch = false;

        public bool DoesHeadTouch()
        {
            return HeadTouch;
        }

        public bool DoesRightHandTouch()
        {
            return RightHandTouch;
        }

        public bool DoesLeftHandTouch()
        {
            return LeftHandTouch;
        }

        public bool DoesRightLegTouch()
        {
            return RightLegTouch;
        }
        public bool DoesLeftLegTouch()
        {
            return LeftLegTouch;
        }

    }
}
