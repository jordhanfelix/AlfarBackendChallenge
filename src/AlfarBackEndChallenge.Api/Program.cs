using System.Reflection;
using AlfarBackEndChallenge.Application;
using AlfarBackEndChallenge.Infrastructure;
using AlfarBackEndChallenge.Application.Utils.Swagger;
using AlfarBackEndChallenge.Api.Common;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddApplicationServicesConfiguration();
builder.Services.AddInfrastructureServicesConfiguration(builder.Configuration);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.EnableAnnotations();

    //Include comments from class documentaiton
    string xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    string xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    c.IncludeXmlComments(xmlPath);

    // Obter todos os assemblies carregados no domínio
    Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();

    // Buscar todas as classes com comentários de documentação
    IEnumerable<Type> classes = assemblies.SelectMany(a => a.GetTypes())
                            .Where(t => t.GetCustomAttributes<SwaggerDocumentationAttribute>().Any());

    // Adicionar as classes ao Swagger para incluir os comentários de documentação
    foreach (Type? classe in classes)
    {
        string xmlCommentsPath = SwaggerComments.GetXmlCommentsFilePath(classe.Assembly);
        c.IncludeXmlComments(xmlCommentsPath);
    }

    //adicionando customizações ao swagger
    c.SchemaFilter<CustomSchemaFilter>();
    c.ParameterFilter<CustomParameterFilter>();  

});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
