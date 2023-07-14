using Asp.Versioning.ApiExplorer;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Reflection;

namespace ApiVersion2
{

    /// <summary>
    /// 
    /// </summary>
    public class ConfigureSwaggerOptions : IConfigureOptions<SwaggerGenOptions>
    {
        private readonly IApiVersionDescriptionProvider provider;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="provider"></param>
        public ConfigureSwaggerOptions(IApiVersionDescriptionProvider provider)
        {
            this.provider = provider;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        public void Configure(SwaggerGenOptions options)
        {
            var XmlPath = $"{Assembly.GetExecutingAssembly().GetName().Name}.XML";
            if (File.Exists(Path.Combine(AppContext.BaseDirectory, XmlPath))) { options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, XmlPath), true); }
            foreach (var description in provider.ApiVersionDescriptions)
            {
                options.SwaggerDoc(description.GroupName, new OpenApiInfo()
                {
                    Title = $"基础 API {description.ApiVersion}",
                    Version = description.ApiVersion.ToString(),
                    Description = $"基础{description.ApiVersion}版本"
                });
            }
        }
    }
}
