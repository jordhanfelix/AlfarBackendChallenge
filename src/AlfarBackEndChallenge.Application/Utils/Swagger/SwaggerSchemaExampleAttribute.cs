using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlfarBackEndChallenge.Application.Utils.Swagger
{
    /// <summary>
    /// Class responsible for configuring settings to force `Swashbuckle.AspNetCore.Annotations` to accept examples in parameter classes
    /// </summary>    
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Parameter | AttributeTargets.Property | AttributeTargets.Enum, AllowMultiple = false)]
    public class SwaggerSchemaExampleAttribute : Attribute
    {
        public SwaggerSchemaExampleAttribute(string exemple)
        {
            Exemple = exemple;
        }

        public string Exemple { get; set; }
    }
}