using System.Reflection;

namespace AlfarBackEndChallenge.Api.Common
{
   public static class SwaggerComments
    {

        // Obter o caminho para o arquivo XML de documentação
        public static string GetXmlCommentsFilePath(Assembly assembly)
        {
            string xmlFile = $"{assembly.GetName().Name}.xml";
            string xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
            return xmlPath;
        }
    }
}