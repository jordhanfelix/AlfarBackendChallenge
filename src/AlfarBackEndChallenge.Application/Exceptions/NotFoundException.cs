using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlfarBackEndChallenge.Application.Exceptions
{
    /// <summary>
    /// Represents an exception that is thrown when a requested resource is not found in the application.
    /// </summary>
    public class NotFoundException : ApplicationException
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="NotFoundException"/> class with no error message.
        /// </summary>
        public NotFoundException(){}
    }

}