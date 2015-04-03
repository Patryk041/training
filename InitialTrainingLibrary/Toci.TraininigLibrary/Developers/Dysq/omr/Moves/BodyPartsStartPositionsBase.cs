using Toci.TraininigLibrary.Developers.Dysq.omr.Interface;

namespace Toci.TraininigLibrary.Developers.Dysq.omr.Moves
{
    public abstract class BodyPartsStartPositionsBase : BodyPartsUseBase
    {
        protected ICoordinates HeadStartPosition = new Coordinates(0,8,0);

        protected ICoordinates RightHandStartPosition = new Coordinates(0,3,0);
        protected ICoordinates LeftHandStartPosition = new Coordinates(0,3,0);

        protected ICoordinates RightLegStartPosition = new Coordinates(0,0,0);
        protected ICoordinates LeftLegStartPosition = new Coordinates(0,0,0);

    }
}
