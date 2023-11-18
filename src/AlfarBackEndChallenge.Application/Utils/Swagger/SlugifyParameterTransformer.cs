using Microsoft.AspNetCore.Routing;
using System.Text.RegularExpressions;

namespace AlfarBackEndChallenge.Application.Utils.Swagger
{
    /// <remarks>
    /// For example, a custom slugify parameter transformer in route pattern blog\{article:slugify} with Url.Action(new { article = "MyTestArticle" }) generates blog\my-test-article.
    /// https://docs.microsoft.com/en-us/aspnet/core/fundamentals/routing?view=aspnetcore-6.0#parameter-transformers
    /// </remarks>
    public class SlugifyParameterTransformer : IOutboundParameterTransformer
    {
        public string? TransformOutbound(object? value)
        {
            if (value is null)
            {
                return null;
            }

            return Regex.Replace(
                    value.ToString()!,
                    "([a-z])([A-Z])",
                    "$1-$2",
                    RegexOptions.CultureInvariant,
                    TimeSpan.FromMilliseconds(100))
                .ToLowerInvariant();
        }
    }
}