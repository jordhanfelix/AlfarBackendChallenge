using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using AlfarBackEndChallenge.Application.Utils.Swagger;

namespace AlfarBackEndChallenge.Application.Models.Requests
{
    public class Customer
    {
        [FromBody]
        [Required]
        [StringLength(255,  MinimumLength = 3)]
        [SwaggerSchemaExample("Jhon Due")]
        [JsonProperty("name")]
        public string Name { get; set; }

        [FromBody]
        [Required]
        [StringLength(20, MinimumLength = 13)]
        [SwaggerSchemaExample("5599999999999")]
        [JsonProperty("phone")]
        public string Phone { get; set; }

        [FromBody]
        [Required]
        [RegularExpression( @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "The email field is not in a valid format.")]
        [StringLength(255,  MinimumLength = 3)]
        [SwaggerSchemaExample("jhon.due@demo.com.br")]
        [JsonProperty("email")]
        public string Email { get; set; }

        [FromBody]
        [Required]
        [SwaggerSchemaExample("1999-01-01")]
        [JsonProperty("date_of_birth")]
        public DateTime DateOfBirth { get; set; }
    }
}