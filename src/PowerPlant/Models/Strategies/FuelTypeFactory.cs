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

        public IFuelTypeStrategy Create(PowerPlantType type)
        {
            switch (type)
            {
                case PowerPlantType.GasFired:
                    return _serviceProvider.GetRequiredService<IGasfiredTypeStrategy>();

                case PowerPlantType.TurboJet:
                    return _serviceProvider.GetRequiredService<ITurboJetTypeStrategy>();

                case PowerPlantType.WindTurbine:
                    return _serviceProvider.GetRequiredService<IWindTurbineTypeStrategy>();

                default:
                    throw new ValidationException("unregistered type");
            }
        }
    }
}
