using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlfarBackEndChallenge.Application.Exceptions
{
    /// <summary>
    /// Represents an exception that is thrown when a bad request is encountered in the application.
    /// </summary>
    public class BadRequestException : ApplicationException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BadRequestException"/> class with no error message.
        /// </summary>
        public BadRequestException(){}
    }
}