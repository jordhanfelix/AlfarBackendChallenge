using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlfarBackEndChallenge.Application.Exceptions
{
    /// <summary>
    /// Represents an exception that is thrown for custom API-related errors in the application.
    /// </summary>
    public class ApiException : ApplicationException
    {
        private readonly int _httpErrorCode;

        /// <summary>
        /// Gets the HTTP error code associated with the exception.
        /// </summary>
        public int HttpErrorCode => _httpErrorCode;

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiException"/> class with a specified error message and HTTP error code.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="httpErrorCode">The HTTP error code associated with the exception.</param>
        public ApiException(string message, int httpErrorCode) : base(message)
        {
            this._httpErrorCode = httpErrorCode;
        }
    }
}