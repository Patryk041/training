using System;

namespace Toci.Hornets.GhostRider.TrainingSeven.Exceptions
{
    public class BusinessLogicProjectException : ProjectException
    {
        public BusinessLogicProjectException(string message, Exception exception, string projectErrorTag) : base(message, exception, projectErrorTag)
        {
        }
    }
}