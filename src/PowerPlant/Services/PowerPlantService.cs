using PowerPlant.Models.Strategies.Interfaces;
using PowerPlant.Models.Views;
using PowerPlant.Services.Interfaces;

namespace PowerPlant.Services
{
    public class PowerPlantService : IPowerPlantService
    {
        private readonly IFuelTypeFactory _fuelTypeFactory;

        public PowerPlantService(IFuelTypeFactory fuelTypeFactory)
        {
            _fuelTypeFactory = fuelTypeFactory;
        }

        public List<PowerPlantResponse> HandlePowerPlantCalculation(PowerPlantRequest powerPlant)
        {
            var response = new List<PowerPlantResponse>();

            foreach (var item in powerPlant.PowerPlants)
            {
                response
                    .Add(_fuelTypeFactory
                    .Create(item.Type)
                    .CalculatePowerPlantProduced(powerPlant, item));
            }

            return response;
        }
    }
}
