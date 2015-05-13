using Toci.TraininigLibrary.Developers.Dysq.omr.Interface;

namespace Toci.TraininigLibrary.Developers.Dysq.omr.Moves
{
    public abstract class BodyPartsUseBase : IMove
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

        public abstract void MoveHead(int x, int y, int z);

        public void MoveRightHand(int x, int y, int z)
        {
            throw new System.NotImplementedException();
        }

        public void MoveLeftHand(int x, int y, int z)
        {
            throw new System.NotImplementedException();
        }

        public void MoveRightLeg(int x, int y, int z)
        {
            throw new System.NotImplementedException();
        }

        public void MoveLeftLeg(int x, int y, int z)
        {
            throw new System.NotImplementedException();
        }
    }
}
