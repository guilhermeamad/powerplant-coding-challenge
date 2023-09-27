using PowerPlant.Models.Strategies.Interfaces;
using PowerPlant.Models.Views;

namespace PowerPlant.Models.Strategies
{
    public class WindTurbineTypeStrategy : IWindTurbineTypeStrategy
    {
        public PowerPlantResponse CalculatePowerPlantProduced(PowerPlantRequest powerPlantList, PowerPlant powerPlant)
        {
            var calc = powerPlantList.Fuels.Wind * powerPlant.Pmax / 100.0;

            return new PowerPlantResponse
            {
                Name = powerPlant.Name,
                Power = powerPlantList.Load > calc ? calc : powerPlantList.Load
            };
        }
    }
}
