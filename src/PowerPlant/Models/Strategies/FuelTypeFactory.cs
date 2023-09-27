using PowerPlant.Models.Strategies.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace PowerPlant.Models.Strategies
{
    public class FuelTypeFactory : IFuelTypeFactory
    {
        private readonly IServiceProvider _serviceProvider;
        public FuelTypeFactory(IServiceProvider serviceProvider) 
        {
            _serviceProvider = serviceProvider;
        }

        public IFuelTypeStrategy Create(string fuelType)
        {
            switch (fuelType)
            {
                case "gasfired":
                    return _serviceProvider.GetRequiredService<IGasfiredTypeStrategy>();

                case "turbojet":
                    return _serviceProvider.GetRequiredService<ITurboJetTypeStrategy>();

                case "windturbine":
                    return _serviceProvider.GetRequiredService<IWindTurbineTypeStrategy>();

                default:
                    throw new ValidationException("unregistered type");
            }
        }
    }
}
