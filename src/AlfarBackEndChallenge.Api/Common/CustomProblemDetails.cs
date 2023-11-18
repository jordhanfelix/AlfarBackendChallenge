using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Net;
using AlfarBackEndChallenge.Application.Utils;
using AlfarBackEndChallenge.Application.Exceptions;

namespace AlfarBackEndChallenge.Api.Common
{
    public class CustomProblemDetails : ProblemDetails
    {
        private string TraceId { get; set; }

        /// <summary>
        /// Create default response for exceptions basad from HTTPStatus
        /// </summary>
        /// <param name="ex">exception object</param>
        public CustomProblemDetails(Exception ex)
        {
            TraceId = Guid.NewGuid().ToString();
            switch (ex)
            {
                case BadRequestException:
                    Title = ApplicationMessages.BAD_REQUEST_MESSAGE;
                    Status = (int)HttpStatusCode.BadRequest;
                    break;
                case NotFoundException:
                    Title = ApplicationMessages.NOT_FOUND_MESSAGE;
                    Status = (int)HttpStatusCode.NotFound;
                    break;
                case UnauthorizedException:
                    Title = ApplicationMessages.UNAUTHORIZED_MESSAGE;
                    Status = (int)HttpStatusCode.Unauthorized;
                    break;
                case SqlException:
                case ArgumentException:
                case ConflictException:
                    Title = ApplicationMessages.CONFLICT_MESSAGE;
                    Status = (int)HttpStatusCode.Conflict;
                    break;
                case ForbiddenException:
                    Title = ApplicationMessages.FORBIDDEN_MESSAGE;
                    Status = (int)HttpStatusCode.Forbidden;
                    break;
                case ApiException apiException:
                    Title = apiException.Message;
                    Status = apiException.HttpErrorCode;
                    break;
                default:
                    Title = ApplicationMessages.INTERNAL_SERVER_ERROR_MESSAGE;
                    Status = (int)HttpStatusCode.InternalServerError;
                    break;
            }
        }

        /// <summary>
        /// Format erros using Instance.
        /// </summary>
        /// <param name="ex"></param>
        /// <param name="request"></param>
        public CustomProblemDetails(Exception ex, HttpRequest request) : this(ex) => Instance = request.Path;

        public CustomProblemDetails()
        {

        }
    }
}