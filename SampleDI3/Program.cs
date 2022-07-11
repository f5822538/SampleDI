using SampleDI3.Class;
using SampleDI3.Interface;
using SampleDI3.Services;

namespace SampleDI3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            #region Sample
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddScoped<IScoped, SampleClass>();
            builder.Services.AddScoped<ISingleton, SampleClass>();
            builder.Services.AddScoped<ITransient, SampleClass>();
            builder.Services.AddScoped<SampleService, SampleService>();
            #endregion Sample

            var app = builder.Build();

            app.MapGet("/", () => "Hello World!");

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }
    }
}