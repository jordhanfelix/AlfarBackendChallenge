using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace AlfarBackEndChallenge.Application.Utils.Swagger
{
    /// <summary>
    /// apply settings to example values ​​in swagger
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class CustomSchemaFilter : ISchemaFilter
    {
        public void Apply(OpenApiSchema schema, SchemaFilterContext context)
        {
            if (context.MemberInfo != null)
            {
                SwaggerSchemaExampleAttribute? schemaAttribute = context.MemberInfo.GetCustomAttributes<SwaggerSchemaExampleAttribute>()
                    .FirstOrDefault();
                if (schemaAttribute != null)
                {
                    ApplySchemaAttribute(schema, schemaAttribute);
                }
            }
        }

        private void ApplySchemaAttribute(OpenApiSchema schema, SwaggerSchemaExampleAttribute schemaAttribute)
        {
            if (schemaAttribute.Exemple != null)
            {
                schema.Example = new Microsoft.OpenApi.Any.OpenApiString(schemaAttribute.Exemple);
            }
        }
    }
}