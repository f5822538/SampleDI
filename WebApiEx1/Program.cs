using SampleDI3.Class;
using SampleDI3.Interface;
using SampleDI3.Services;

namespace WebApiEx1
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

            // Add services to the container.
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

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
        }
    }
}