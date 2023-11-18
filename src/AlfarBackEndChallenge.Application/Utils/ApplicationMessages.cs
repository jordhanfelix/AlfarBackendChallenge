using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlfarBackEndChallenge.Application.Utils
{
    /// <summary>
    /// Provides a central repository for application messages including errors and other informational messages.
    /// </summary>
    public static class ApplicationMessages
    {

    #region HTTP Status Codes

    /// <summary>
    /// Message for OK (HTTP Status Code: 200).
    /// </summary>
    public const string SUCCESS_MESSAGE = "operation completed successfully.";

    /// <summary>
    /// Message for Created (HTTP Status Code: 201).
    /// </summary>
    public const string CREATED_MESSAGE = "created.";

    /// <summary>
    /// Message for No Content (HTTP Status Code: 204).
    /// </summary>
    public const string NO_CONTENT_MESSAGE = "no content.";

    /// <summary>
    /// Message for Multiple Choices (HTTP Status Code: 300).
    /// </summary>
    public const string MULTIPLE_CHOICES_MESSAGE = "multiple choices.";

    /// <summary>
    /// Message for Moved Permanently (HTTP Status Code: 301).
    /// </summary>
    public const string MOVED_PERMANENTLY_MESSAGE = "moved permanently.";

    /// <summary>
    /// Message for Found (HTTP Status Code: 302).
    /// </summary>
    public const string FOUND_MESSAGE = "found.";

    /// <summary>
    /// Message for Bad Request (HTTP Status Code: 400).
    /// </summary>
    public const string BAD_REQUEST_MESSAGE = "bad request.";

    /// <summary>
    /// Message for Unauthorized (HTTP Status Code: 401).
    /// </summary>
    public const string UNAUTHORIZED_MESSAGE = "unauthorized.";

    /// <summary>
    /// Message for Forbidden (HTTP Status Code: 403).
    /// </summary>
    public const string FORBIDDEN_MESSAGE = "forbidden.";

    /// <summary>
    /// Message for Not Found (HTTP Status Code: 404).
    /// </summary>
    public const string NOT_FOUND_MESSAGE = "not found.";

    /// <summary>
    /// Message for Internal Server Error (HTTP Status Code: 500).
    /// </summary>
    public const string INTERNAL_SERVER_ERROR_MESSAGE = "internal server error.";

    /// <summary>
    /// Message for Not Implemented (HTTP Status Code: 501).
    /// </summary>
    public const string NOT_IMPLEMENTED_MESSAGE = "not implemented.";

    /// <summary>
    /// Message for Service Unavailable (HTTP Status Code: 503).
    /// </summary>
    public const string SERVICE_UNAVAILABLE_MESSAGE = "service unavailable.";

    #endregion

    #region Custom Messages

    /// <summary>
    /// Welcome message for users.
    /// </summary>
    public const string WELCOME_MESSAGE = "welcome!";   

    /// <summary>
    /// Message for conflict error.
    /// </summary>
    public const string CONFLICT_MESSAGE = "a data conflict has occurred.";

    /// <summary>
    /// Message for unprocessable entity error.
    /// </summary>
    public const string UNPROCESSABLE_ENTITY_MESSAGE = "unprocessable entity.";

    // Add more custom messages as needed

    #endregion
    }
}