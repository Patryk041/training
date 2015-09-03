using System;

namespace Toci.Hornets.GhostRider.TrainingSeven.Exceptions
{
    public abstract class ProjectException : ApplicationException
    {
        public string ProjectErrorTag { get; protected set; }

        // _err_db_consistency_same_id_for_the_same_person
        protected ProjectException(string message, Exception exception, string projectErrorTag) : base(message, exception) // i18n internationalization
        {
            //InnerException = exception;
            ProjectErrorTag = projectErrorTag;
        }
    }
}