using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlfarBackEndChallenge.Application.Exceptions
{
    /// <summary>
    /// Represents an exception that is thrown when a conflict is encountered in the application.
    /// </summary>
    public class ConflictException : ApplicationException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConflictException"/> class with no error message.
        /// </summary>
        public ConflictException(){}
    }

}