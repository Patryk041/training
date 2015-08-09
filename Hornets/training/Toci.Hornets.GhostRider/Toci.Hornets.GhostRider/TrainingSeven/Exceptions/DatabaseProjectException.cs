using System;

namespace Toci.Hornets.GhostRider.TrainingSeven.Exceptions
{
    public class DatabaseProjectException : ProjectException
    {
        public DatabaseProjectException(string message, Exception exception, string projectErrorTag) : base(message, exception, projectErrorTag)
        {
        }
    }
}