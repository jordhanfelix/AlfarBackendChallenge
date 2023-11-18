using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;
using AlfarBackEndChallenge.Application.Contracts.Infrastructure.Services;
using AlfarBackEndChallenge.Api.Common;
using AlfarBackEndChallenge.Application.Models;

namespace AlfarBackEndChallenge.Api.Controllers
{
    [Tags("Costumers")]
    [ApiController]
    [Route("api/customers")]
    [Produces("application/json")]
    public class CustomerController : ControllerBase
    {
        
        private readonly ICustomerService _service;

        public CustomerController(ICustomerService service)
        {
            _service = service;
        }

        /// <summary>
        /// Represents operations for retrieving customer data.
        /// </summary>
        [HttpGet()]
        [SwaggerResponse(200, "Customers retrieved successfully", typeof(List<string>))]
        [SwaggerResponse(404, "Customer not found", typeof(ProblemDetails))]
        [SwaggerResponse(500, "Internal server error", typeof(ProblemDetails))]
        public async Task<ActionResult> Get()
        {
            try
            {
                _uow.Customer.FindByCondition().FirstOrDefault() ?? throw new NotFoundException();

                List<string> data = new List<string> {"teste", "teste2", "teste3"};

                return StatusCode(StatusCodes.Status200OK, new Response<List<string>>(data));
            }
            catch (Exception ex)
            {
                CustomProblemDetails result = new CustomProblemDetails(ex, Request);
                return StatusCode(result.Status.Value, result);
            }
        }
    }
}