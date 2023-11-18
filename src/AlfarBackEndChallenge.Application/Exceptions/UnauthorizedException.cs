using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlfarBackEndChallenge.Application.Exceptions
{
    /// <summary>
    /// Represents an exception that is thrown when an unauthorized access is detected in the application.
    /// </summary>
    public class UnauthorizedException : ApplicationException
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="UnauthorizedException"/> class with no error message.
        /// </summary>
        public UnauthorizedException()
        {
            // Additional initialization, if needed
        }
    }
}