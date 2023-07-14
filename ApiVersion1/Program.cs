using ApiVersion1;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerUI;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    var XmlPath = $"{Assembly.GetExecutingAssembly().GetName().Name}.XML";
    if (File.Exists(Path.Combine(AppContext.BaseDirectory, XmlPath))) { options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, XmlPath), true); }
    typeof(FrameworkEnum.ApiVersion).GetEnumNames().ToList().ForEach(version => { options.SwaggerDoc(version, new OpenApiInfo { Title = "基础", Version = version.ToString(), Description = $"基础{version}版本" }); });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        typeof(FrameworkEnum.ApiVersion).GetEnumNames().ToList().ForEach(version => { options.SwaggerEndpoint($"/swagger/{version}/swagger.json", $"版本{version}"); });
        options.DocExpansion(DocExpansion.None); // 设置为None可折叠所有方法
        options.DefaultModelsExpandDepth(0); // 设置为-1 可不显示Models
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
