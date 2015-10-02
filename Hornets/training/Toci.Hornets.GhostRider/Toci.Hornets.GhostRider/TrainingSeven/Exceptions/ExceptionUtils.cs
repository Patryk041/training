using System;
using System.Collections.Generic;

namespace Toci.Hornets.GhostRider.TrainingSeven.Exceptions
{
    public class ExceptionUtils
    {
        private List<string> customErrTags = new List<string>();

        public List<string> GetExceptionCustomMessages(Exception exception)
        {
            var exc = exception as ProjectException;

            if (exc != null)
            {
                customErrTags.Add(exc.ProjectErrorTag);

                if (exc.InnerException != null)
                {
                    GetExceptionCustomMessages(exc.InnerException);
                }
            }

            return customErrTags;
        }
    }
}