using PowerPlant.Models.Strategies;
using PowerPlant.Models.Strategies.Interfaces;
using PowerPlant.Services;
using PowerPlant.Services.Interfaces;

namespace PowerPlant
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddScoped<IFuelTypeFactory, FuelTypeFactory>();
            builder.Services.AddScoped<IGasfiredTypeStrategy, GasfiredTypeStrategy>();
            builder.Services.AddScoped<ITurboJetTypeStrategy, TurboJetTypeStrategy>();
            builder.Services.AddScoped<IWindTurbineTypeStrategy, WindTurbineTypeStrategy>();
            builder.Services.AddScoped<IPowerPlantService, PowerPlantService>();

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