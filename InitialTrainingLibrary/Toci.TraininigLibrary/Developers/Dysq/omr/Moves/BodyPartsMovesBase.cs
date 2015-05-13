using Toci.TraininigLibrary.Developers.Dysq.omr.Interface;

namespace Toci.TraininigLibrary.Developers.Dysq.omr.Moves
{
    public abstract class BodyPartsMovesBase : BodyPartsStartPositionsBase
    {
        public int xCoordinate { get; set; }
        public int yCoordinate { get; set; }
        public int zCoordinate { get; set; }

        protected ICoordinates HeadAfterMove;
        protected ICoordinates RightHandAfterMove;
        protected ICoordinates LeftHandAfterMove;
        protected ICoordinates RightLegAfterMove;
        protected ICoordinates LeftLegAfterMove;

        protected BodyPartsMovesBase(int xCoor, int yCoor, int zCoor)
        {
        }

        public override void MoveHead( int x, int y, int z)
        {
            HeadAfterMove = new Coordinates(x + this.HeadStartPosition.GetX(), y + this.HeadStartPosition.GetY(), z + this.HeadStartPosition.GetZ());
            
        }

        public virtual void MoveRightHand(int x, int y, int z)
        {
            RightHandAfterMove = new Coordinates(x + this.RightHandStartPosition.GetX(), y + this.RightHandStartPosition.GetY(), z + this.RightHandStartPosition.GetZ());
           
        }

        public virtual void MoveLeftHand(int x, int y, int z)
        {
            LeftHandAfterMove = new Coordinates(x + this.LeftHandStartPosition.GetX(), y + this.LeftHandStartPosition.GetY(), z + this.LeftHandStartPosition.GetZ());
         
        }

        public virtual void MoveRightLeg(int x, int y, int z)
        {
            RightLegAfterMove = new Coordinates(x + this.RightLegStartPosition.GetX(), y + this.RightLegStartPosition.GetY(), z + this.RightLegStartPosition.GetZ());
            
        }

        public virtual void MoveLeftLeg(int x, int y, int z)
        {
            LeftLegAfterMove = new Coordinates(x + this.LeftLegStartPosition.GetX(), y + this.LeftLegStartPosition.GetY(),
                z + this.LeftLegStartPosition.GetZ());
         
        }

    }
}
