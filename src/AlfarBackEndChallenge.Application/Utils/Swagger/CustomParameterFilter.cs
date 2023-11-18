using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace AlfarBackEndChallenge.Application.Utils.Swagger
{
    public class CustomParameterFilter : IParameterFilter
    {
        public void Apply(OpenApiParameter parameter, ParameterFilterContext context)
        {
            IEnumerable<SwaggerParameterExampleAttribute> parameterAttributes = null;

            if (context.PropertyInfo != null)
            {
                parameterAttributes = context.PropertyInfo.GetCustomAttributes<SwaggerParameterExampleAttribute>();
            }
            else if (context.ParameterInfo != null)
            {
                parameterAttributes = context.ParameterInfo.GetCustomAttributes<SwaggerParameterExampleAttribute>();
            }

            if (parameterAttributes != null && parameterAttributes.Any())
            {
                AddExemple(parameter, parameterAttributes);
            }

        }

        private void AddExemple(OpenApiParameter parameter, IEnumerable<SwaggerParameterExampleAttribute> parameterExampleAttributes)
        {
            foreach (SwaggerParameterExampleAttribute item in parameterExampleAttributes)
            {

                OpenApiExample exemple = new OpenApiExample
                {
                    Value = new Microsoft.OpenApi.Any.OpenApiString(item.Value)
                };

                parameter.Examples.Add(item.Name, exemple);
            }
        }
    }
}