using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlfarBackEndChallenge.Application.Exceptions
{
    /// <summary>
    /// Represents an exception that is thrown when access to a resource is forbidden in the application.
    /// </summary>
    public class ForbiddenException : ApplicationException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ForbiddenException"/> class with no error message.
        /// </summary>
        public ForbiddenException(){}
    
    }
}